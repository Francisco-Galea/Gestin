using Gestin.Model.Dao;
using Gestin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gestin.Controllers
{
    internal class subjectController
    {
        sessionController sessionController = sessionController.getInstance();
        careerController? careerController = careerController.getInstance();
        SubjectDao subjectDao = new SubjectDao();

        #region Singletone

        private static subjectController? Instance;

        private subjectController() { }

        public static subjectController getInstance()
        {
            if (Instance == null)
            {
                Instance = new subjectController();
            }
            return Instance;
        }
        #endregion

        #region Loaders

        /// <summary>
        /// Loads all subjects from the data source.
        /// </summary>
        /// <returns>A list of subjects.</returns>
        public List<Subject> loadSubjects()
        {
            return subjectDao.loadSubjects();
        }

        #endregion

        #region Subject

        public int countSubjects()
        {
            return subjectDao.countSubjects();
        }

        public int getSubjectsFromCareerCount(int careerId)
        {
            return subjectDao.getSubjectsFromCareerCount(careerId);
        }

        public int getSubjectsFromCareerCount(object careerObject)
        {
            return subjectDao.getSubjectsFromCareerCount(careerObject);
        }

        public int getSubjectCountFromCareerEnrolment(object selectedCareer)
        {
            return subjectDao.getSubjectCountFromCareerEnrolment(selectedCareer);
        }

        public Subject findSubject(object subject)
        {
            return (Subject)subject;
        }

        public Subject findSubject(int subjectID)
        {
            return subjectDao.findSubject(subjectID);
        }

        public Subject findSubject(string subjectName, int careerId)
        {
            return subjectDao.findSubject(subjectName, careerId);
        }

        public int getSubjectId(object subjectObject)
        {
            return ((Subject)subjectObject).Id;
        }

        public string getSubjectName(object subject)
        {
            return ((Subject)subject).Name;
        }

        public int getSubjectYearInCareer(object subject)
        {
            return ((Subject)subject).YearInCareer;
        }

        public List<Subject> getSubjectsFromCareer(int careerid)
        {
            return subjectDao.getSubjectsFromCareer(careerid);
        }

        public List<Subject> getSubjectsFromCareer(object career)
        {
            return subjectDao.getSubjectsFromCareer(career);
        }

        public List<Subject> getSubjectsFromCareerAndYearInCarrer(int careerid, int yearInCarrer)
        {
            return subjectDao.getSubjectsFromCareerAndYearInCarrer(careerid, yearInCarrer);
        }

        public List<Subject> getSubjectsFromCareerByYear(object selectedCareer, int year)
        {
            return subjectDao.getSubjectsFromCareerByYear(selectedCareer, year);
        }

        /// <summary>
        /// Creates a new subject within an existing career.
        /// </summary>
        /// <param name="existingCareer">The Career object where the new subject will be added.</param>
        /// <param name="name">The name of the new subject.</param>
        /// <param name="yearInCareer">The year within the career in which the subject is taught.</param>
        /// <param name="annualTotalHours">The total annual hours required for the subject.</param>
        /// <param name="cupof">The capacity (cupo) for the subject.</param>
        /// <returns>Returns true if the subject is successfully created; otherwise, false.</returns>
        public bool createSubject(object existingCareer, string name, int yearInCareer, int annualTotalHours, string cupof)
        {
            var career = (Career)existingCareer;

            if (subjectDao.checkDuplicateSubjectName(career, name))
            {
                return false;
            }

            var newSubject = buildSubject(career.Id, name, yearInCareer, annualTotalHours, cupof);

            if (saveNewSubject(newSubject))
            {
                updateCareerSubjectCount(career.Id);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Builds a new Subject object based on the specified parameters.
        /// </summary>
        /// <param name="careerId">The ID of the career associated with the subject.</param>
        /// <param name="name">The name of the new subject.</param>
        /// <param name="yearInCareer">The academic year in which the subject is taught within the career.</param>
        /// <param name="annualTotalHours">The total number of hours per year for the subject.</param>
        /// <param name="cupof">The capacity (cupo) for the subject.</param>
        /// <returns>A new Subject object with the specified details.</returns>
        private Subject buildSubject(int careerId, string name, int yearInCareer, int annualTotalHours, string cupof)
        {
            return new Subject
            {
                CareerId = careerId,
                Name = name,
                YearInCareer = yearInCareer,
                AnnualHourlyLoad = annualTotalHours,
                Cupof = cupof,
                CreatedAt = DateTime.Now,
                LastModificationBy = sessionController.getSessionedUserData()
            };
        }

        private bool saveNewSubject(Subject subject)
        {
            return subjectDao.saveNewSubject(subject);
        }

        /// <summary>
        /// Updates an existing subject's information.
        /// </summary>
        /// <param name="existingSubject">The Subject object to be updated.</param>
        /// <param name="name">The updated name of the subject.</param>
        /// <param name="yearInCareer">The updated academic year in which the subject is taught within the career.</param>
        /// <param name="annualTotalHours">The updated total annual hours for the subject.</param>
        /// <param name="cupof">The updated capacity (cupo) for the subject.</param>
        /// <returns>Returns true if the subject is successfully updated; otherwise, false.</returns>
        public bool updateSubject(object existingSubject, string name, int yearInCareer, int annualTotalHours, string cupof)
        {
            var subject = (Subject)existingSubject;
            updateSubjectAttributes(subject, name, yearInCareer, annualTotalHours, cupof);

            return saveUpdatedSubject(subject);
        }

        /// <summary>
        /// Updates the attributes of a Subject object based on the specified parameters.
        /// </summary>
        /// <param name="subject">The Subject object to be updated.</param>
        /// <param name="name">The new name of the subject.</param>
        /// <param name="yearInCareer">The new academic year in which the subject is taught within the career.</param>
        /// <param name="annualTotalHours">The new total annual hours for the subject.</param>
        /// <param name="cupof">The new capacity (cupo) for the subject.</param>
        private void updateSubjectAttributes(Subject subject, string name, int yearInCareer, int annualTotalHours, string cupof)
        {
            subject.Name = name;
            subject.YearInCareer = yearInCareer;
            subject.AnnualHourlyLoad = annualTotalHours;
            subject.Cupof = cupof;
            subject.LastModificationBy = sessionController.getSessionedUserData();
            subject.UpdatedAt = DateTime.Now;
        }

        private bool saveUpdatedSubject(Subject subject)
        {
            return subjectDao.saveUpdatedSubject(subject);
        }

        /// <summary>
        /// Marks a subject as deleted without removing it from the database.
        /// </summary>
        /// <param name="existingSubject">The subject object to mark as deleted.</param>
        /// <returns>Returns true if the subject was successfully marked as deleted and the career subject count was updated; otherwise, false.</returns>
        public bool softDeleteSubject(object existingSubject)
        {
            var subject = (Subject)existingSubject;
            markSubjectAsDeleted(subject);

            if (saveSubjectChanges(subject))
            {
                return updateCareerSubjectCount(subject.CareerId);
            }
            return false;
        }

        /// <summary>
        /// Updates the subject to reflect it as deleted by setting the deletion timestamp and last modification details.
        /// </summary>
        /// <param name="subject">The subject to mark as deleted.</param>
        private void markSubjectAsDeleted(Subject subject)
        {
            subject.LastModificationBy = sessionController.getSessionedUserData();
            subject.DeletedAt = DateTime.Now;
        }

        public bool updateCareerSubjectCount(int careerId)
        {
            return subjectDao.updateCareerSubjectCount(careerId);
        }

        private bool saveSubjectChanges(Subject subject)
        {
            return subjectDao.saveUpdatedSubject(subject);
        }

        public List<Subject> getSubjectsExceptSame(Career selectedCareer, Subject selectedSubject)
        {
            return careerController.loadSubjectsFromCareer(selectedCareer).Where(x => x.Id != selectedSubject.Id).ToList();
        }

        public Subject? getSpecificSubjectFromCareer(object selectedCareer, int subjectID)
        {
            return careerController.loadSubjectsFromCareer((Career)selectedCareer).FirstOrDefault(x => x.Id == subjectID);
        }

        public Subject? getSpecificSubjectFromCareer(Career selectedCareer, Subject selectedSubject)
        {
            return careerController.loadSubjectsFromCareer(selectedCareer).FirstOrDefault(x => x.Id == selectedSubject.Id);
        }

        /// <summary>
        /// Retrieves the total weekly hours for a specific subject.
        /// </summary>
        /// <param name="subjectID">The unique identifier of the subject.</param>
        /// <returns>The total number of weekly hours for the subject.</returns>
        public int getWeeklyHoursFromSubject(int subjectID)
        {
            var subject = findSubject(subjectID);
            return CalculateWeeklyHours(subject);
        }

        /// <summary>
        /// Calculates the weekly hours based on the annual hourly load of a subject.
        /// </summary>
        /// <param name="subject">The Subject object from which to obtain the hourly load.</param>
        /// <returns>The number of weekly hours; returns 0 if the object is null.</returns>
        private int CalculateWeeklyHours(Subject? subject)
        {
            if (subject == null)
            {
                return 0;
            }

            return CalculateHours(subject.AnnualHourlyLoad);
        }

        /// <summary>
        /// Calculates the weekly hours for a subject based on its total annual hours.
        /// </summary>
        /// <param name="annualHourlyLoad">The total annual hours allocated to the subject.</param>
        /// <returns>The calculated weekly hours. Returns 0 if the annual hourly load is 0.</returns>
        private int CalculateHours(int annualHourlyLoad)
        {
            if (annualHourlyLoad == 0)
            {
                return 0;
            }

            return annualHourlyLoad / 32;
        }

        /// <summary>
        /// Counts the number of subjects associated with a specific career by its ID.
        /// </summary>
        /// <param name="careerid">The unique identifier of the career.</param>
        /// <returns>The total number of subjects associated with the career.</returns>
        public int countSubjectsFromCareer(int careerid)
        {
            return getSubjectsFromCareer(careerid).Count;
        }

        /// <summary>
        /// Counts the number of subjects associated with a specific career object.
        /// </summary>
        /// <param name="careerSelected">The career object whose subjects are to be counted.</param>
        /// <returns>The total number of subjects associated with the career.</returns>
        public int countSubjectsFromCareer(object careerSelected)
        {
            Career career = (Career)careerSelected;
            return careerController.loadSubjectsFromCareer(career).Count;
        }
        #endregion
    }
}
