using Gestin.Model;
using Gestin.Model.Model_Internal;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Gestin.Controllers
{
    internal class examEnrolmentController
    {
        careerController careerController = careerController.getInstance();
        gradeController gradeController = gradeController.getInstance();
        sessionController sessionController = sessionController.getInstance();
        correlativeController correlativeController = correlativeController.getInstance();

        #region Singletone

        private static examEnrolmentController? Instance;
        private examEnrolmentController() { }

        public static examEnrolmentController getInstance()
        {
            if (Instance == null)
            {
                Instance = new examEnrolmentController();
            }
            return Instance;
        }
        #endregion

        #region ExamEnrolment
        public (bool, Dictionary<Subject, int>?) verifyCorrelatives(int subject, int studentId)
        {
            Dictionary<Subject, int> GradesDict = new Dictionary<Subject, int>();
            bool enabled = true;
            List<Correlative> ListCorrelatives = correlativeController.getCorrelativesFromSubject(subject);
            using (var db = new Context())
            {
                try
                {
                    foreach (Correlative item in ListCorrelatives)
                    {
                        int grade = gradeController.getLastGrade(item.CorrelativeSubject, studentId);
                        if (grade < 4) enabled = false;
                        GradesDict.Add(item.CorrelativeSubject, grade);
                    }
                    return (enabled, GradesDict);
                }
                catch { return (false, null); }
            }
        }
        public bool enrolStudentToExam(int studentId, int examId)
        {
            try
            {
                ExamEnrolment exEnrol = new ExamEnrolment();
                exEnrol.StudentId = studentId;
                exEnrol.ExamId = examId;
                exEnrol.CreatedAt = DateTime.Now;
                exEnrol.LastModificationBy = sessionController.getSessionedUserData();
                using (var db = new Context())
                {
                    db.ExamEnrolments.Add(exEnrol);
                    db.SaveChanges();
                }
                return true;
            }
            catch { return (false); }
        }
        public List<Student> getEnroledStudent(int IdExam)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.ExamEnrolments.Where(x => (x.ExamId == IdExam && x.DeletedAt == null)).Include(x => x.Student.User).Select(x => x.Student).OrderBy(x => x.User.LastName).ToList();
                }
                catch (SqlException) { throw; }
            }
        }
        public int countEnroledStudent(int examId)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.ExamEnrolments.Count(x => (x.DeletedAt == null && x.ExamId == examId));
                }
                catch (SqlException) { throw; }
            }
        }

        public int countEnroledStudent(object studentExam)
        {
            ExamEnrolment examEnrolment = (ExamEnrolment)studentExam;
            using (var db = new Context())
            {
                try
                {
                    return db.ExamEnrolments.Count(x => (x.DeletedAt == null && x.ExamId == examEnrolment.ExamId));
                }
                catch (SqlException) { throw; }
            }
        }

        public ExamEnrolment? findExamEnrolment(int studentId, Exam exam)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.ExamEnrolments.Where(x => (x.StudentId == studentId && x.ExamId == exam.Id)).FirstOrDefault();
                }
                catch (SqlException) { throw; }
            }
        }

        public List<ExamEnrolment> findExamEnrolments(Student selectedStudent, StudentRecord studentRecord)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.ExamEnrolments.Where(x => x.StudentId == selectedStudent.Id && x.Exam.IdSubject == studentRecord.Subject.Id).ToList();
                }
                catch (SqlException) { throw; }
            }
        }

        public List<ExamEnrolment> obtainTheExamsToWhichAStudentRegisters(int studentId)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.ExamEnrolments.Where(x => (x.StudentId == studentId) && x.Exam.Date >= DateTime.Today).Include(x => x.Exam.IdSubjectNavigation).Include(x => x.Exam.IdSubjectNavigation.Career).ToList();
                }
                catch (SqlException) { throw; }
            }
        }

        public List<Exam> obtainTheExamsToWhichAStudentRegisters(object student)
        {
            Student student1 = (Student)student;
            using (var db = new Context())
            {
                try
                {
                    return db.ExamEnrolments.Where(x => (x.StudentId == student1.Id) && x.Exam.Date >= DateTime.Today).Include(x => x.Exam.IdSubjectNavigation).Select(x => x.Exam).ToList();
                }
                catch (SqlException) { throw; }
            }
        }


        public (bool, string) unrolStudent(object student, object thisExam)
        {
            Exam exam = (Exam)thisExam;
            try
            {
                Student stu = (Student)student;
                var _exam = findExamEnrolment(stu.Id, exam);
                _exam.DeletedAt = DateTime.Now;
                using (var db = new Context())
                {
                    db.Update(_exam);
                    db.SaveChanges();
                    return (true, "Estudiante dado de baja correctamente");
                }
            }
            catch (Exception exception) { return (false, exception.Message); }
        }
        public (bool, string) unrolStudent(int Idstudent, Exam exam)
        {
            try
            {
                var _exam = findExamEnrolment(Idstudent, exam);
                using (var db = new Context())
                {
                    db.ExamEnrolments.Remove(_exam);
                    db.SaveChanges();
                    return (true, "Estudiante dado de baja correctamente");
                }
            }
            catch (Exception exception) { return (false, exception.Message); }
        }

        public bool checkStudentInExams(object selectedStudent, object selectedStudentRecord)
        {
            Student student = (Student)selectedStudent;
            StudentRecord studentRecord = (StudentRecord)selectedStudentRecord;
            try
            {
                using (var db = new Context())
                {
                    return db.ExamEnrolments.Any(x => x.StudentId == student.Id && x.Exam.IdSubject == studentRecord.Subject.Id);
                }
            }
            catch (SqlException) { throw; }
        }

        public bool unrolStudentAllExams(object selectedStudent, object selectedStudentRecord)
        {
            Student student = (Student)selectedStudent;
            StudentRecord studentRecord = (StudentRecord)selectedStudentRecord;

            List<ExamEnrolment> enrolments = findExamEnrolments(student, studentRecord);
            try
            {
                using (var db = new Context())
                {
                    foreach(var enrolment in enrolments)
                    {
                        db.ExamEnrolments.Remove(enrolment);
                    }
                    return db.SaveChanges() > 0;
                }
            }
            catch (SqlException) { throw; }
        }


        #endregion
    }
}
