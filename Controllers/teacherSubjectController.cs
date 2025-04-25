using Gestin.Exceptions;
using Gestin.Model;
using Gestin.Model.Dao;
using Gestin.Properties;
using Gestin.UI.Custom;
using Gestin.Validators;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Controllers
{
    internal class teacherSubjectController
    {
        careerController? careerController;
        subjectController? subjectController;
        teacherController? teacherController;
        sessionController sessionController = sessionController.getInstance();
        TeacherSubjectDao teacherSubjectDao = new TeacherSubjectDao();

        #region Singletone

        private static teacherSubjectController? Instance;

        private teacherSubjectController() { }

        public static teacherSubjectController getInstance()
        {
            if (Instance == null)
            {
                Instance = new teacherSubjectController();
            }
            return Instance;
        }
        #endregion

        #region Loaders

        public List<TeacherSubject> loadTeachersSubjects()
        {
            return teacherSubjectDao.loadTeachersSubjects();
        }

        #endregion

        #region TeacherSubject

        /// <summary>
        /// Assigns a teacher to a subject with a specific condition, creating or editing a teacher-subject charge.
        /// </summary>
        /// <param name="teacher">The teacher to be assigned.</param>
        /// <param name="subject">The subject to assign the teacher to.</param>
        /// <param name="condition">The condition under which the teacher is assigned (e.g., "Suplente").</param>
        /// <returns>
        /// A boolean value indicating whether the operation was successful.
        /// </returns>
        public bool assignTeacherCharge(object teacher, object subject, string condition)
        {
            Teacher selectedTeacher = (Teacher)teacher;
            Subject selectedSubject = (Subject)subject;
            TeacherSubject createdCharge = createTeacherSubject(selectedTeacher, selectedSubject, condition);
            return editCharge(createdCharge, selectedTeacher, selectedSubject);
        }

        /// <summary>
        /// Creates a new TeacherSubject entity for the given teacher and subject with the specified condition.
        /// </summary>
        /// <param name="teacher">The teacher associated with the charge.</param>
        /// <param name="subject">The subject associated with the charge.</param>
        /// <param name="condition">The condition of the charge (e.g., "Suplente").</param>
        /// <returns>
        /// A new <see cref="TeacherSubject"/> entity with the specified attributes.
        /// </returns>
        private TeacherSubject createTeacherSubject(Teacher teacher, Subject subject, string condition)
        {
            return new TeacherSubject
            {
                TeacherId = teacher.Id,
                SubjectId = subject.Id,
                DateSince = null,
                DateUntil = null,
                Active = true,
                Condition = condition,
                CreatedAt = DateTime.Now,
                LastModificationBy = sessionController.getSessionedUserData()
            };
        }

        /// <summary>
        /// Reassigns an existing teacher-subject charge to a subject, marking it as active and updating modification metadata.
        /// </summary>
        /// <param name="charge">The existing teacher-subject charge to be reassigned.</param>
        /// <param name="subject">The subject to assign the charge to.</param>
        /// <returns>
        /// A boolean value indicating whether the operation was successful.
        /// </returns>

        public bool assignTeacherCharge(object charge, object subject)
        {
            TeacherSubject selectedCharge = (TeacherSubject)charge;
            Subject selectedSubject = (Subject)subject;
            selectedCharge.UpdatedAt = DateTime.Now;
            selectedCharge.LastModificationBy = sessionController.getSessionedUserData();
            selectedCharge.Active = true;

            return editCharge(selectedCharge, null, selectedSubject);
        }

        /// <summary>
        /// Edits or adds a teacher-subject charge, ensuring proper conditions for assigning the charge.
        /// </summary>
        /// <param name="createdCharge">The teacher-subject charge to be added or edited.</param>
        /// <param name="teacher">The teacher associated with the charge (nullable for certain operations).</param>
        /// <param name="selectedSubject">The subject associated with the charge.</param>
        /// <returns>
        /// A boolean value indicating whether the operation was successful.
        /// </returns>

        public bool editCharge(TeacherSubject createdCharge, Teacher? teacher, Subject selectedSubject)
        {
            if (!getAllActiveTeacherCharges(selectedSubject).Any() && !createdCharge.Condition.Equals("Suplente"))
            {
                try
                {
                    using (var db = new Context())
                    {
                        db.TeacherSubjects.Add(createdCharge);
                        return db.SaveChanges() > 0;
                    }
                }
                catch (SqlException) { throw; }
                catch (Exception) { throw; }
            }
            else if (createdCharge.Condition.Equals("Suplente") && getAllActiveNonSubstituteTeacherCharges(selectedSubject).Any())
            {
                try
                {
                    using (var db = new Context())
                    {
                        db.TeacherSubjects.Add(createdCharge);
                        return db.SaveChanges() > 0;
                    }
                }
                catch (SqlException) { throw; }
                catch (Exception) { throw; }
            }
            else if (!createdCharge.Condition.Equals("Suplente"))
            {
                try
                {
                    TeacherSubject? activeCharge = getActiveNonSubstituteCharge(selectedSubject);

                    if (activeCharge == null) { throw new ArgumentNullException(); }

                    if (!checkIfTeacherAlreadyInCharge(createdCharge, activeCharge))
                    {
                        using (var db = new Context())
                        {
                            db.TeacherSubjects.Add(createdCharge);
                            deactivateTeacherCharge(activeCharge);
                            return db.SaveChanges() > 0;
                        }
                    }
                    else { throw new ExistingTeacherChargeException($"Mismo docente en el cargo: {activeCharge.Condition}"); }
                }
                catch (SqlException) { throw; }
                catch (Exception) { throw; }
            }
            return false;
        }

        /// <summary>
        /// Checks if the teacher in the given charge is already assigned as active for the specified subject.
        /// </summary>
        /// <param name="existingCharge">The teacher-subject charge to be checked.</param>
        /// <param name="activeCharge">The currently active teacher-subject charge for the subject.</param>
        /// <returns>
        /// A boolean value indicating whether the teacher in the given charge is already active.
        /// </returns>

        public bool checkIfTeacherAlreadyInCharge(TeacherSubject existingCharge, TeacherSubject? activeCharge)
        {
            if (activeCharge != null && existingCharge.TeacherId == activeCharge.TeacherId)
            {

                return true;
            }
            return false;
        }

        public void changeChargeDates(object selectedCharge, DateTime datesince, DateTime dateuntil)
        {
            teacherSubjectDao.changeChargeDates(selectedCharge, datesince, dateuntil);
        }

        public bool deactivateTeacherCharge(TeacherSubject currentActive)
        {
            return teacherSubjectDao.deactivateTeacherCharge(currentActive);
        }

        public bool deactivateTeacherCharge(object currentActive)
        {
            return teacherSubjectDao.deactivateTeacherCharge(currentActive);
        }

        public void deactivateTeacherCharge(int id, string condition)
        {
            teacherSubjectDao.deactivateTeacherCharge(id, condition);
        }

        public List<TeacherSubject> activeTeacherCharges()
        {
            return teacherSubjectDao.activeTeacherCharges();
        }

        public TeacherSubject? findTeacherCharge(object objectTeacherCharge)
        {
            return teacherSubjectDao.findTeacherCharge(objectTeacherCharge);
        }

        public TeacherSubject findTeacherCharge(int teacherchargeID)
        {
            return teacherSubjectDao.findTeacherCharge(teacherchargeID);
        }

        public TeacherSubject findTeacherCharge(object objectTeacherCharge, object objectSubject)
        {
            return teacherSubjectDao.findTeacherCharge(objectTeacherCharge, objectSubject);
        }

        public List<TeacherSubject> getTeacherSubjects(Teacher teacher)
        {
            return teacherSubjectDao.getTeacherSubjects(teacher);
        }

        public List<TeacherSubject> getTeachersFromSubject(object objectSubject)
        {
            return teacherSubjectDao.getTeachersFromSubject(objectSubject);
        }

        public List<TeacherSubject> getAllTeachersFromSubject(object objectSubject)
        {
            return teacherSubjectDao.getAllTeachersFromSubject(objectSubject);
        }

        public List<TeacherSubject> getTeachersFromSubject(int subjectId)
        {
            return teacherSubjectDao.getTeachersFromSubject(subjectId);
        }

        public TeacherSubject? getActiveNonSubstituteCharge(Subject existingsubject)
        {
            return teacherSubjectDao.getActiveNonSubstituteCharge(existingsubject);
        }

        public List<TeacherSubject> getAllActiveTeacherCharges(object subject)
        {
            return teacherSubjectDao.getAllActiveTeacherCharges(subject);
        }

        public List<TeacherSubject> getAllActiveTeacherChargesBySubject(int idSubject)
        {
            return teacherSubjectDao.getAllActiveTeacherChargesBySubject(idSubject);
        }

        public List<TeacherSubject> getAllActiveTeacherChargesByTeacher(int idTeacher)
        {
            return teacherSubjectDao.getAllActiveTeacherChargesByTeacher(idTeacher);
        }

        public List<TeacherSubject> getAllActiveNonSubstituteTeacherCharges(Subject existingSubject)
        {
            return teacherSubjectDao.getAllActiveNonSubstituteTeacherCharges(existingSubject);
        }

        /// <summary>
        /// Filters the active teachers assigned to a subject based on their role (Titular, Provisional, or Suplente).
        /// </summary>
        /// <param name="subjectId">The ID of the subject for which the teachers are to be filtered.</param>
        /// <returns>
        /// A formatted string containing the names of active teachers assigned to the subject, prioritized as follows:
        /// - The active *Titular* teacher (if any), with their substitute (if any).
        /// - The active *Provisional* teacher (if any), with their substitute (if any).
        /// - The most recently updated active *Suplente* teacher, if no Titular or Provisional is active.
        /// </returns>
        public string filterSubjectTeachers(int subjectId)
        {
            string? result = "";
            List<TeacherSubject> teacherSubjects = getTeachersFromSubject(subjectId);

            TeacherSubject? Titular = teacherSubjects.Where(x => x.Condition.Equals("Titular") && x.Active).FirstOrDefault();
            if (Titular != null) { teacherSubjects.Remove(Titular); };

            TeacherSubject? Provisional = teacherSubjects.Where(x => x.Condition.Equals("Provisional") && x.Active).FirstOrDefault();
            if (Provisional != null) { teacherSubjects.Remove(Provisional); };

            //Trae el suplente activo mas reciente
            TeacherSubject? Substitute = teacherSubjects.Where(x => x.Condition.Equals("Suplente") && x.Active).OrderByDescending(x => x.UpdatedAt).FirstOrDefault();

            if (Titular != null) //Existe un titular activo
            {
                result += $"\n [{Titular.Teacher.getUserFullName()}] ";

                if (Substitute != null) //Puede existir un Titular activo con un suplente
                {
                    result += $"\n [Suplente: {Substitute.Teacher.getUserFullName()}]";
                }
            }
            else if (Provisional != null)
            {
                result += $"\n [Provisional: {Provisional.Teacher.getUserFullName()}]";

                if (Substitute != null) //Puede existir un Provisional activo con un suplente
                {
                    result += $"\n [Suplente: {Substitute.Teacher.getUserFullName()}]";
                }
            }
            else if (Substitute != null)
            {
                result += $"\n [Suplente: {Substitute.Teacher.getUserFullName()}]";
            }
            return result;
        }
        #endregion
    }
}
