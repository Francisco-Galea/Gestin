using Gestin.Model;
using Gestin.Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Controllers
{
    internal class correlativeController
    {
        CorrelativeDao correlativeDao = new CorrelativeDao();
        careerController? careerController;
        subjectController? subjectController = subjectController.getInstance();
        sessionController sessionController = sessionController.getInstance();

        #region Singletone

        private static correlativeController? Instance;

        private correlativeController() { }

        public static correlativeController getInstance()
        {
            if (Instance == null)
            {
                Instance = new correlativeController();
            }
            return Instance;
        }
        #endregion

        #region Loaders

        public List<Correlative> loadCorrelatives()
        {
            return correlativeDao.loadCorrelatives();
        }

        public List<Subject> loadFutureCorrelativesSubjects(Subject subject)
        {
            return correlativeDao.loadFutureCorrelativesSubjects(subject);
        }

        /// <summary>
        /// Loads correlative branches for a list of enrolled subjects, returning a combined list of distinct correlatives.
        /// </summary>
        /// <param name="subjectsEnrolled">The list of subjects enrolled by the student.</param>
        /// <returns>A combined list of distinct future correlatives for the enrolled subjects.</returns>
        public List<Subject> loadCorrelativesBranches(List<Subject> subjectsEnrolled)
        {
            var correlativeInnerBranchA = loadFirstBranchCorrelatives(subjectsEnrolled);
            var correlativeInnerBranchB = loadSecondBranchCorrelatives(correlativeInnerBranchA);

            return combineDistinctCorrelatives(correlativeInnerBranchA, correlativeInnerBranchB);
        }

        /// <summary>
        /// Loads the first branch of future correlatives for a list of enrolled subjects.
        /// </summary>
        /// <param name="subjectsEnrolled">The list of enrolled subjects.</param>
        /// <returns>A list of first-level future correlatives for the enrolled subjects.</returns>
        private List<Subject> loadFirstBranchCorrelatives(List<Subject> subjectsEnrolled)
        {
            var correlativeBranchA = new List<Subject>();
            foreach (var enrolledSubject in subjectsEnrolled)
            {
                correlativeBranchA.AddRange(loadFutureCorrelativesSubjects(enrolledSubject));
            }
            return correlativeBranchA;
        }

        /// <summary>
        /// Loads the second branch of future correlatives for a list of subjects from the first branch.
        /// </summary>
        /// <param name="firstBranchCorrelatives">The list of first branch correlatives.</param>
        /// <returns>A list of second-level future correlatives for the first branch subjects.</returns>
        private List<Subject> loadSecondBranchCorrelatives(List<Subject> firstBranchCorrelatives)
        {
            var correlativeBranchB = new List<Subject>();
            foreach (var correlativeA in firstBranchCorrelatives)
            {
                correlativeBranchB.AddRange(loadFutureCorrelativesSubjects(correlativeA));
            }
            return correlativeBranchB;
        }

        /// <summary>
        /// Combines two branches of correlatives into a single list of distinct correlatives.
        /// </summary>
        /// <param name="branchA">The first branch of correlatives.</param>
        /// <param name="branchB">The second branch of correlatives.</param>
        /// <returns>A combined list of distinct correlatives from both branches.</returns>
        private List<Subject> combineDistinctCorrelatives(List<Subject> branchA, List<Subject> branchB)
        {
            var distinctCorrelatives = new List<Subject>();
            distinctCorrelatives.AddRange(branchA.Distinct());
            distinctCorrelatives.AddRange(branchB.Distinct());
            return distinctCorrelatives;
        }
        #endregion

        #region Correlatives

        /// <summary>
        /// Creates a new correlative relationship between two subjects and saves it to the database.
        /// </summary>
        /// <param name="objectSubject">The primary subject in the correlative relationship.</param>
        /// <param name="objectCorrelativeSubject">The subject that is a correlative of the primary subject.</param>
        /// <param name="state">The status of the correlative relationship.</param>
        /// <exception cref="InvalidOperationException">Thrown if there is an error while saving the correlative.</exception>
        public void createCorrelative(object objectSubject, object objectCorrelativeSubject, bool state)
        {
            var newCorrelative = createNewCorrelative(objectSubject, objectCorrelativeSubject, state);
            saveCorrelative(newCorrelative);
        }

        /// <summary>
        /// Creates a new correlative instance with the specified attributes.
        /// </summary>
        /// <param name="objectSubject">The primary subject in the correlative relationship.</param>
        /// <param name="objectCorrelativeSubject">The subject that is a correlative of the primary subject.</param>
        /// <param name="state">The status of the correlative relationship.</param>
        /// <returns>A new instance of <see cref="Correlative"/> representing the correlative relationship.</returns>
        private Correlative createNewCorrelative(object objectSubject, object objectCorrelativeSubject, bool state)
        {
            var selectedSubject = (Subject)objectSubject;
            var correlativeSubject = (Subject)objectCorrelativeSubject;

            return new Correlative
            {
                SubjectId = selectedSubject.Id,
                CorrelativeSubjectId = correlativeSubject.Id,
                CorrelativeFinal = state,
                CreatedAt = DateTime.Now,
                LastModificationBy = sessionController.getSessionedUserData()
            };
        }

        /// <summary>
        /// Saves the specified correlative instance to the database.
        /// </summary>
        /// <param name="correlative">The correlative instance to save.</param>
        /// <exception cref="SqlException">Thrown if an error occurs while saving the correlative to the database.</exception>
        private void saveCorrelative(Correlative correlative)
        {
            correlativeDao.saveCorrelative(correlative);
        }

        public void removeCorrelative(int id)
        {
            correlativeDao.removeCorrelative(id);

        }

        public Correlative findCorrelative(object objectCorrelative)
        {
            return correlativeDao.findCorrelative(objectCorrelative);
        }

        public Correlative findCorrelative(int IDcorrelative)
        {
            return correlativeDao.findCorrelative(IDcorrelative);
        }

        public List<Subject> getSubjectsFromCorrelatives(object objectSubject)
        {
            return correlativeDao.getSubjectsFromCorrelatives(objectSubject);
        }

        /// <summary>
        /// Retrieves a list of enabled correlatives for the specified career and subject.
        /// </summary>
        /// <param name="objectCareer">The career object to consider for correlatives.</param>
        /// <param name="objectSubject">The subject object to find correlatives for.</param>
        /// <param name="special">Determines if the correlatives should be filtered for a special condition.</param>
        /// <returns>A list of enabled correlatives for the specified subject and career.</returns>
        public List<Subject> getEnabledCorrelatives(object objectCareer, object objectSubject, bool special)
        {
            var selectedCareer = (Career)objectCareer;
            var selectedSubject = (Subject)objectSubject;

            var allSubjects = getFilteredSubjects(selectedCareer, selectedSubject, special);
            var correlativeSubjects = getSubjectsFromCorrelatives(selectedSubject);

            removeCorrelativeSubjects(allSubjects, correlativeSubjects);

            return allSubjects;
        }

        /// <summary>
        /// Filters subjects based on the selected career, subject, and special condition.
        /// </summary>
        /// <param name="selectedCareer">The career to filter subjects for.</param>
        /// <param name="selectedSubject">The subject used as a reference for filtering.</param>
        /// <param name="special">If true, applies a special filtering condition.</param>
        /// <returns>A filtered list of subjects.</returns>
        private List<Subject> getFilteredSubjects(Career selectedCareer, Subject selectedSubject, bool special)
        {
            var allSubjects = subjectController.getSubjectsExceptSame(selectedCareer, selectedSubject);

            if (special)
            {
                allSubjects.RemoveAll(x => x.YearInCareer > selectedSubject.YearInCareer);
            }
            else
            {
                allSubjects.RemoveAll(x => x.YearInCareer >= selectedSubject.YearInCareer);
            }

            return allSubjects;
        }

        /// <summary>
        /// Removes subjects that are already correlatives from the list of all subjects.
        /// </summary>
        /// <param name="allSubjects">The list of all subjects to filter from.</param>
        /// <param name="correlativeSubjects">The list of subjects that are correlatives.</param>
        private void removeCorrelativeSubjects(List<Subject> allSubjects, List<Subject> correlativeSubjects)
        {
            if (correlativeSubjects.Any())
            {
                allSubjects.RemoveAll(x => correlativeSubjects.Any(y => y.Id == x.Id));
            }
        }

        public List<Correlative> getCorrelativesFromSubject(Subject existingsubject)
        {
            return correlativeDao.getCorrelativesFromSubject(existingsubject);
        }

        public List<Correlative> getCorrelativesFromSubject(int IdSubject)
        {
            return correlativeDao.getCorrelativesFromSubject(IdSubject);
        }
        #endregion
    }
}
