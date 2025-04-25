using Gestin.Model.Dao;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Context = Gestin.Model.Context;

namespace Gestin.Controllers
{
    internal class statisticsController
    {
        sessionController sessionController = sessionController.getInstance();
        StatisticsDao statisticsDao = new StatisticsDao();

        #region Singletone
        private static statisticsController? Instance;

        private statisticsController() { }

        public static statisticsController getInstance()
        {
            if (Instance == null)
            {
                Instance = new statisticsController();
            }
            return Instance;
        }
        #endregion

        public int getTotalEnrolmentsByCareerBySubject(int careerId, int subjectId, int Year)
        {
            return statisticsDao.getTotalEnrolmentsByCareerBySubject(careerId, subjectId, Year);
        }

        public int getFreeEnrolmentsBySubjectByYear(int idSubject, int Year)
        {
            return statisticsDao.getFreeEnrolmentsBySubjectByYear(idSubject, Year);
        }

        public int getPresentialEnrolmentsBySubjectByYear(int idSubject, int Year)
        {
            return statisticsDao.getPresentialEnrolmentsBySubjectByYear(idSubject, Year);
        }

        public int getFreeEnrolmentsByCareerByCourse(int idCareer, int YearInCareer)
        {
            return statisticsDao.getFreeEnrolmentsByCareerByCourse(idCareer, YearInCareer);
        }

        public int getPresentialEnrolmentsByCareerByCourse(int idCareer, int YearInCareer)
        {
            return statisticsDao.getPresentialEnrolmentsByCareerByCourse(idCareer, YearInCareer);
        }

        public int getMaleEnrolmentsByCareer(int idCareer, int Year)
        {
            return statisticsDao.getMaleEnrolmentsByCareer(idCareer, Year);
        }

        public int getMaleEnrolmentsByCareerBySubjectByYear(int idCareer, int idSubject, int Year)
        {
            return statisticsDao.getMaleEnrolmentsByCareerBySubjectByYear(idCareer, idSubject, Year);
        }

        public int getFemaleEnrolmentsByCareer(int idCareer, int Year)
        {
            return statisticsDao.getFemaleEnrolmentsByCareer(idCareer, Year);
        }

        public int getFemaleEnrolmentsByCareerBySubjectByYear(int idCareer, int idSubject, int Year)
        {
            return statisticsDao.getFemaleEnrolmentsByCareerBySubjectByYear(idCareer, idSubject, Year);
        }

        public int getOtherGenderEnrolmentsByCareer(int idCareer, int Year)
        {
            return statisticsDao.getOtherGenderEnrolmentsByCareer(idCareer, Year);
        }

        public int getEnrolmentsByCareerByCourse(int YearInCareer, int Year)
        {
            return statisticsDao.getEnrolmentsByCareerByCourse(YearInCareer, Year);
        }

        public int getEnrolmentsByCareerByYear(int idCareer, int Year)
        {
            return statisticsDao.getEnrolmentsByCareerByYear(idCareer, Year);
        }

        public int getAcademicDelaysByCareerBySubject(int subjectId, int Year)
        {
            return statisticsDao.getAcademicDelaysByCareerBySubject(subjectId, Year);
        }

        public int getTotalAcademicDelaysByCourse(int year)
        {
            return statisticsDao.getTotalAcademicDelaysByCourse(year);
        }

        public int getTotalAcademicDelaysByCareer(int year)
        {
            return statisticsDao.getTotalAcademicDelaysByCareer(year);
        }

        public int getNotAcademicDelaysByCareerBySubject(int subjectId, int Year)
        {
            return statisticsDao.getNotAcademicDelaysByCareerBySubject(subjectId, Year);
        }

        public int getRecurrentStudentsBySubjectAndYearInCareer(int subjectId, int year)
        {
            return statisticsDao.getRecurrentStudentsBySubjectAndYearInCareer(subjectId, year);
        }

        public int getTotalRecurrentStudentsByYear(int year)
        {
            return statisticsDao.getTotalRecurrentStudentsByYear(year);
        }

        public int getTotalRecurrentStudents()
        {
            return statisticsDao.getTotalRecurrentStudents();
        }
    }
}
