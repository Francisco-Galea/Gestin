using DocumentFormat.OpenXml.Bibliography;
using Gestin.Model;
using Gestin.Model.Dao;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Gestin.Controllers
{
    /// <summary>
    /// CareerEnromentl Controller
    /// </summary>
    internal class careerEnrolmentController
    {
        gradeController? gradeController = gradeController.getInstance();
        careerController careerController = careerController.getInstance();
        CareerEnrolmentDao careerEnrolmentDao = new CareerEnrolmentDao();
        sessionController sessionController = sessionController.getInstance();
        subjectController? subjectController = subjectController.getInstance();

        #region Singleton

        private static careerEnrolmentController? Instance;
        private object lista;

        private careerEnrolmentController() { }

        public static careerEnrolmentController getInstance()
        {
            if (Instance == null)
            {
                Instance = new careerEnrolmentController();
            }
            return Instance;
        }
        #endregion


        #region CareerEnrolment

        #region DAO

        /// <summary>
        /// Gets DAO careerEnrolments by DNI
        /// </summary>
        /// <param name="dni">Student's dni</param>
        /// <returns>Student's list of careerEnrolment</returns>
        public List<CareerEnrolment> searchCareerEnrolments(int dni)
        {
            return careerEnrolmentDao.searchCareerEnrolmentsByDni(dni);
        }

        /// <summary>
        /// Gets all enrollments to a career by idCareer
        /// </summary>
        /// <param name="idCareer">CareerId</param>
        /// <returns>List of CareerEnrolment</returns>
        private List<CareerEnrolment> getEnrolmentsByCareer(int idCareer)
        {
           return careerEnrolmentDao.getEnrolmentsByCareerId(idCareer);
        }

        /// <summary>
        /// Enrols a student to a career.
        /// </summary>
        /// <param name="studentObject">Student to enrol.</param>
        /// <param name="careerObject">Career to enrol to</param>
        /// <param name="year">Enrolment's year</param>
        /// <returns>True if were successful</returns>
        public bool enrolStudent(object studentObject, object careerObject, int year)
        {
            return careerEnrolmentDao.addCareerEnrolment(buildCareerEnrolment(studentObject, careerObject, year));
        }

        /// <summary>
        /// Gets a list of all the careers in which a student is enrolled.
        /// </summary>
        /// <param name="dni">Student's DNI</param>
        /// <returns>Career's list</returns>
        public List<Career> GetCareersByStudentDNI(int dni)
        {
            return careerEnrolmentDao.getCareersByStudentDNI(dni);
        }

        #endregion

        #region GetMethods

        /// <summary>
        /// Getter of CareerId atribute of CareerEnrolment
        /// </summary>
        /// <param name="careerEnrolment">CareerEnrolment objetct</param>
        /// <returns>Career id</returns>
        public int getCareerEnrolmentCareerId(object careerEnrolment)
        {
            return castToCareerEnrolemt(careerEnrolment).CareerId;
        }

        /// <summary>
        /// Gets a list of available careers student can enroll.
        /// </summary>
        /// <param name="dni">Student's dni</param>
        /// <returns>A list of student's enrollable careers</returns>
        public List<Career> searchEnrollableCareers(int dni)
        {
            List<Career> allAvailableCareers = careerController.loadCareersActive();
            List<Career> careerEnrolments = searchCareerEnrolments(dni).Select(x => x.Career).ToList();
            allAvailableCareers.RemoveAll(x => careerEnrolments.Any(y => y.Id == x.Id));
            return allAvailableCareers;
        }

        /// <summary>
        /// Gets career's subject quantity
        /// </summary>
        /// <param name="selectedCareerEnrolment">CareerEnrolment</param>
        /// <returns>Career's subject quantity</returns>
        internal int? getCareerSubjectNumber(object selectedCareerEnrolment)
        {
            return castToCareerEnrolemt(selectedCareerEnrolment).Career.TotalAmountSubjects;
        }

        /// <summary>
        /// Gets a list of Student's grade's average.
        /// </summary>
        /// <param name="careerSelected">Career to get grade's average list.</param>
        /// <param name="onlyGraduted">If wants only graduated student's grade average list.</param>
        /// <returns>List of careerEnrolment</returns>
        internal List<CareerEnrolment> getAverageListByOption(object careerSelected, bool onlyGraduted)
        {
            return onlyGraduted ? graduatesListByCareer(castToCareer(careerSelected).Id) :graduatesOnlyList(castToCareer(careerSelected).Id);
        }

        /// <summary>
        /// Getter of a list of studen's grade's average.
        /// Student's full name, student dni, passedSubjects, careerPorcentage and grade's average.
        /// Configure the variables needed to construct the list, and return it builded
        /// </summary>
        /// <param name="careerSubjectCount">A number of career's subjects</param>
        /// <param name="enrol">CareerEnrolment object</param>
        /// <param name="careerSelected">Career to search in</param>
        /// <returns>A list with Student's full name, student dni, passedSubjects, careerPorcentage and grade's average</returns>
        internal List<dynamic> getAverageData(int careerSubjectCount, object enrol, object careerSelected) 
        {    
            List<Grade> grades = gradeController.getStudentGradesFromCareer(castToCareerEnrolemt(enrol).Student.User.Dni, castToCareer(careerSelected).Id);
            return buildListOfStudentData(castToCareerEnrolemt(enrol), castToCareer(careerSelected), castToCareerEnrolemt(enrol).Student.User.Dni, grades, careerSubjectCount);
        }

        /// <summary>
        /// Gets a list of enrollments with at least one subject graded.
        /// </summary>
        /// <param name="careerId">idCareer</param>
        /// <returns>A list of CareerEnrolments </returns>
        private List<CareerEnrolment> graduatesOnlyList(int careerId)
        {
            var enrolments = getEnrolmentsByCareer(careerId);
            var gradedEnrolments = new List<CareerEnrolment>();
            foreach (var enrol in enrolments)
            {
                if (gradeController.countPassedSubjects(enrol.Student.User.Dni, enrol.CareerId) > 0)
                {
                    gradedEnrolments.Add(enrol);
                }
            }
            return gradedEnrolments;
        }

        /// <summary>
        /// Gets the career's completion percentage of a student
        /// </summary>
        /// <param name="careerId">Id of the career</param>
        /// <param name="dni">Student's dni</param>
        /// <returns>The completion percentage of a student's career</returns>
        public double careerCompletionPercentageByCareerId(int careerId, int dni)
        {
            int passedSubjects = gradeController.countPassedSubjects(dni, careerId);
            int careerSubjectCount = subjectController.getSubjectsFromCareerCount(careerId);
            return careerCompletionPercentage(passedSubjects, careerSubjectCount);
        }
       
        /// <summary>
        /// Gets students from a career who have already graduated.
        /// </summary>
        /// <param name="careerId">An id of the wanted career</param>
        /// <returns>CareerEnrolment's list</returns>
        private List<CareerEnrolment> graduatesListByCareer(int careerId)
        {
            var lista = getEnrolmentsByCareer(careerId);
            var graduatesList = new List<CareerEnrolment>();

            foreach (var enrol in lista)
            {
                if (verifyIfTheStudentIsGraduate(careerId, enrol.Student.Id))
                {
                    graduatesList.Add(enrol);
                }
            }
            return graduatesList;
        }
        #endregion

        #region UtilityMethods

        /// <summary>
        /// Instanciate an object of CareerEnrolment
        /// </summary>
        /// <param name="studentObject">Studen to enrol</param>
        /// <param name="careerObject">Career to enrol</param>
        /// <param name="year">Enrolment's year</param>
        /// <returns>A CareerEnrolmet object</returns>
        private CareerEnrolment buildCareerEnrolment(object studentObject, object careerObject, int year)
        {
            Student student = (Student)studentObject;
            CareerEnrolment enrol = new CareerEnrolment();
            enrol.StudentId = student.Id;
            enrol.CareerId = castToCareer(careerObject).Id;
            enrol.YearOfRegistration = year;
            enrol.CreatedAt = DateTime.Now;
            enrol.LastModificationBy = sessionController.getSessionedUserData(); 
            return enrol;
        }

        /// <summary>
        /// Builds the student's grade's average list .
        /// </summary>
        /// <param name="careerEnrolment">CareerEnrolmentObject</param>
        /// <param name="career">Career object</param>
        /// <param name="studentDni">Student's dni</param>
        /// <param name="grades">Grades of student</param>
        /// <param name="careerSubjectCount">Number of career's subject</param>
        /// <returns>A list with Student's full name, student dni, passedSubjects, careerPorcentage and grade's average</returns>
        private List<dynamic> buildListOfStudentData(CareerEnrolment careerEnrolment, Career career, int studentDni, List<Grade> grades, int careerSubjectCount)
        {
            List<dynamic> averageData = new()
            {
                careerEnrolment.Student.getUserFullName(),
                studentDni,
                grades.Count(),
                careerCompletionPercentage(  grades.Count(), careerSubjectCount).ToString() + " %",
                calculateAverage(gradeController.getStudentGradesFromCareer(studentDni, career.Id))
            };

            return averageData;
        }

        /// <summary>
        /// Calculates the average of grades of student
        /// Grade list already has the grades greater/equal that of 4
        /// </summary>
        /// <param name="gradeList">Grades to calculate average</param>
        /// <returns>GradeList's average</returns>
        private double calculateAverage(List<Grade> gradeList)
        {
            double avg = 0;
            avg = gradeList.Average(x => x.Grade1);

            return Math.Round(avg, 2);
        }

        /// <summary>
        /// Calculates career's completion percentage.
        /// </summary>
        /// <param name="passedSubjects">The number of passed subjects</param>
        /// <param name="careerSubjectCount">The number of subjects by career</param>
        /// <returns>Returns a completion percentage of the career</returns>
        private double careerCompletionPercentage(int passedSubjects, int careerSubjectCount)
        {
            return passedSubjects * 100 / careerSubjectCount;
        }

        /// <summary>
        /// Verifies if a student is graduate or not.
        /// </summary>
        /// <param name="careerId">An id of carrer</param>
        /// <param name="studentId">An id of a student</param>
        /// <returns>True if the student is graduta</returns>
        public bool verifyIfTheStudentIsGraduate(int careerId, int studentId)
        {
            return subjectController.countSubjectsFromCareer(careerId) == gradeController.countApprovedSubjects(careerId, studentId) ? true : false;
        }

        /// <summary>
        /// This method attempts to cast an object to a CareerEnrolment type. 
        /// If the cast is successful, the CareerEnrolment instance is returned. 
        /// If the cast fails, an ArgumentException is thrown.
        /// </summary>
        /// <param name="careerEnrolment">CareerEnrolment</param>
        /// <returns>CareerEnrolment</returns>
        /// <exception cref="ArgumentException"></exception>
        private CareerEnrolment castToCareerEnrolemt(object careerEnrolment)
        {

            try
            {
                return (CareerEnrolment)careerEnrolment;
            }
            catch (Exception)
            {
                throw new ArgumentException("El parámetro debe ser de tipo CareerEnrolment", nameof(careerEnrolment));
            }
            
        }

        /// <summary>
        /// This method should be in the careerController.
        /// This method attempts to cast an object to a Career type. 
        /// If the cast is successful, the Career instance is returned. 
        /// If the cast fails, an ArgumentException is thrown.
        /// </summary>
        /// <param name="career">Career</param>
        /// <returns>Career</returns>
        /// <exception cref="ArgumentException"></exception>
        private Career castToCareer(object career) {
            try
            {
                return (Career)career;
            }
            catch (Exception)
            {
                throw new ArgumentException("El parámetro debe ser de tipo Career", nameof(career));
            }
        }

        #endregion

        #endregion



    }
}
