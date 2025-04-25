using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Model.Dao
{
    public class StatisticsDao
    {
        /// <summary>
        /// Retrieves the total number of enrolments for a specific subject within a career for a given year.
        /// </summary>
        /// <param name="careerId">The ID of the career.</param>
        /// <param name="subjectId">The ID of the subject.</param>
        /// <param name="Year">The year of the enrolment.</param>
        /// <returns>The count of unique enrolments.</returns>
        public int getTotalEnrolmentsByCareerBySubject(int careerId, int subjectId, int Year)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.SubjectEnrolments
                                .Where(se => se.SubjectId == subjectId && se.Year == Year && se.DeletedAt == null && se.DeletedAt == null)
                                .Join(db.Subjects,
                                      se => se.SubjectId,
                                      s => s.Id,
                                      (se, s) => new { se.StudentId, se.SubjectId, s.Name, s.CareerId, se.Year })
                                .Where(sub => sub.CareerId == careerId)
                                .Distinct()
                                .Count();
                    return result;
                }
                catch (SqlException) { throw; }
            }
        }

        /// <summary>
        /// Retrieves the number of non-presential (free) enrolments for a specific subject in a given year.
        /// </summary>
        /// <param name="idSubject">The ID of the subject.</param>
        /// <param name="Year">The year of the enrolment.</param>
        /// <returns>The count of unique non-presential enrolments.</returns>
        public int getFreeEnrolmentsBySubjectByYear(int idSubject, int Year)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.SubjectEnrolments
                                .Where(se => se.Presential == false && se.SubjectId == idSubject && se.Year == Year && se.DeletedAt == null)
                                .Join(db.Subjects,
                                      se => se.SubjectId,
                                      s => s.Id,
                                      (se, s) => new { s.Name, se.Year, se.Presential, se.StudentId })
                                .Distinct()
                                .Count();


                    return result;
                }
                catch (SqlException) { throw; }
            }
        }

        /// <summary>
        /// Retrieves the number of presential enrolments for a specific subject in a given year.
        /// </summary>
        /// <param name="idSubject">The ID of the subject.</param>
        /// <param name="Year">The year of the enrolment.</param>
        /// <returns>The count of unique presential enrolments.</returns>
        public int getPresentialEnrolmentsBySubjectByYear(int idSubject, int Year)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.SubjectEnrolments
                                .Where(se => se.Presential == true && se.SubjectId == idSubject && se.Year == Year && se.DeletedAt == null)
                                .Join(db.Subjects,
                                      se => se.SubjectId,
                                      s => s.Id,
                                      (se, s) => new { s.Name, se.Year, se.Presential, se.StudentId })
                                .Distinct()
                                .Count();


                    return result;

                }
                catch (SqlException) { throw; }
            }
        }

        /// <summary>
        /// Retrieves the count of non-presential enrolments for a specific course within a career.
        /// </summary>
        /// <param name="idCareer">The ID of the career.</param>
        /// <param name="YearInCareer">The year within the career.</param>
        /// <returns>The count of non-presential enrolments for the given course.</returns>
        public int getFreeEnrolmentsByCareerByCourse(int idCareer, int YearInCareer)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.CareerEnrolments
                        .Include(ce => ce.Student)
                        .ThenInclude(s => s.SubjectEnrolments)
                        .ThenInclude(se => se.Subject)
                        .Where(ce => ce.CareerId == idCareer &&
                                     ce.Student.SubjectEnrolments.Any(se => !se.Presential && se.Subject.YearInCareer == YearInCareer && se.DeletedAt == null))
                        .Select(ce => ce.StudentId)
                        .Distinct()
                        .Count();

                    return result;

                }
                catch (SqlException) { throw; }
            }
        }

        /// <summary>
        /// Retrieves the count of presential enrolments for a specific course within a career.
        /// </summary>
        /// <param name="idCareer">The ID of the career.</param>
        /// <param name="YearInCareer">The year within the career.</param>
        /// <returns>The count of presential enrolments for the given course.</returns>
        public int getPresentialEnrolmentsByCareerByCourse(int idCareer, int YearInCareer)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.CareerEnrolments
                                .Include(ce => ce.Student)
                                .ThenInclude(s => s.SubjectEnrolments)
                                .ThenInclude(se => se.Subject)
                                .Where(ce => ce.CareerId == idCareer &&
                                             ce.Student.SubjectEnrolments.Any(se => se.Presential == true && se.Subject.YearInCareer == YearInCareer && se.DeletedAt == null))
                                .Select(ce => ce.StudentId)
                                .Distinct()
                                .Count();

                    return result;
                }
                catch (SqlException) { throw; }
            }
        }


        /// <summary>
        /// Retrieves the number of male enrolments within a specific career and year.
        /// </summary>
        /// <param name="idCareer">The ID of the career.</param>
        /// <param name="Year">The year of the enrolment.</param>
        /// <returns>The count of male enrolments.</returns>
        public int getMaleEnrolmentsByCareer(int idCareer, int Year)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = (from u in db.Users
                                  join s in db.Students on u.Id equals s.UserId
                                  join ce in db.CareerEnrolments on s.Id equals ce.StudentId
                                  join se in db.SubjectEnrolments on s.Id equals se.StudentId
                                  where u.Gender == "Masculino" && ce.CareerId == idCareer && se.Year == Year && se.DeletedAt == null
                                  select u).Distinct().Count();
                    return result;

                }
                catch (SqlException) { throw; }
            }
        }

        /// <summary>
        /// Retrieves the number of male enrolments within a specific career, subject, and year.
        /// </summary>
        /// <param name="idCareer">The ID of the career.</param>
        /// <param name="idSubject">The ID of the subject.</param>
        /// <param name="Year">The year of the enrolment.</param>
        /// <returns>The count of male enrolments for the specified subject.</returns>
        public int getMaleEnrolmentsByCareerBySubjectByYear(int idCareer, int idSubject, int Year)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Users
                                    .Join(db.Students,
                                        u => u.Id,
                                        s => s.UserId,
                                        (u, s) => new { u, s })
                                    .Join(db.CareerEnrolments,
                                        us => us.s.Id,
                                        ce => ce.StudentId,
                                        (us, ce) => new { us.u, us.s, ce })
                                    .Join(db.SubjectEnrolments,
                                        usc => usc.s.Id,
                                        se => se.StudentId,
                                        (usc, se) => new { usc.u, usc.ce, se })
                                    .Where(x => x.u.Gender == "Masculino" && x.ce.CareerId == idCareer && x.se.SubjectId == idSubject && x.se.Year == Year && x.se.DeletedAt == null)
                                    .Distinct()
                                    .Count();
                    return result;
                }
                catch (SqlException) { throw; }
            }
        }

        /// <summary>
        /// Retrieves the number of female enrolments within a specific career and year.
        /// </summary>
        /// <param name="idCareer">The ID of the career.</param>
        /// <param name="Year">The year of the enrolment.</param>
        /// <returns>The count of female enrolments.</returns>
        public int getFemaleEnrolmentsByCareer(int idCareer, int Year)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = (from u in db.Users
                                  join s in db.Students on u.Id equals s.UserId
                                  join ce in db.CareerEnrolments on s.Id equals ce.StudentId
                                  join se in db.SubjectEnrolments on s.Id equals se.StudentId
                                  where u.Gender == "Femenino" && ce.CareerId == idCareer && se.Year == Year && se.DeletedAt == null
                                  select u).Distinct().Count();
                    return result;
                }
                catch (SqlException) { throw; }
            }
        }

        /// <summary>
        /// Retrieves the number of female enrolments within a specific career, subject, and year.
        /// </summary>
        /// <param name="idCareer">The ID of the career.</param>
        /// <param name="idSubject">The ID of the subject.</param>
        /// <param name="Year">The year of the enrolment.</param>
        /// <returns>The count of female enrolments for the specified subject.</returns>
        public int getFemaleEnrolmentsByCareerBySubjectByYear(int idCareer, int idSubject, int Year)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Users
                                    .Join(db.Students,
                                        u => u.Id,
                                        s => s.UserId,
                                        (u, s) => new { u, s })
                                    .Join(db.CareerEnrolments,
                                        us => us.s.Id,
                                        ce => ce.StudentId,
                                        (us, ce) => new { us.u, us.s, ce })
                                    .Join(db.SubjectEnrolments,
                                        usc => usc.s.Id,
                                        se => se.StudentId,
                                        (usc, se) => new { usc.u, usc.ce, se })
                                    .Where(x => x.u.Gender == "Femenino" && x.ce.CareerId == idCareer && x.se.SubjectId == idSubject && x.se.Year == Year && x.se.DeletedAt == null)
                                    .Distinct()
                                    .Count();
                    return result;
                }
                catch (SqlException) { throw; }
            }
        }


        /// <summary>
        /// Retrieves the count of "Other" gender enrolments within a specific career and year.
        /// </summary>
        /// <param name="idCareer">The ID of the career.</param>
        /// <param name="Year">The year of the enrolment.</param>
        /// <returns>The count of "Other" gender enrolments.</returns>
        public int getOtherGenderEnrolmentsByCareer(int idCareer, int Year)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = (from u in db.Users
                                  join s in db.Students on u.Id equals s.UserId
                                  join ce in db.CareerEnrolments on s.Id equals ce.StudentId
                                  join se in db.SubjectEnrolments on s.Id equals se.SubjectId
                                  where u.Gender == "Otro" && ce.CareerId == idCareer && se.Year == Year && se.DeletedAt == null
                                  select u).Count();
                    return result;
                }
                catch (SqlException) { throw; }
            }
        }

        /// <summary>
        /// Retrieves the number of enrolments within a specific course and year across careers.
        /// </summary>
        /// <param name="YearInCareer">The year within the career.</param>
        /// <param name="Year">The enrolment year.</param>
        /// <returns>The count of enrolments for the specified course and year.</returns>
        public int getEnrolmentsByCareerByCourse(int YearInCareer, int Year)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.SubjectEnrolments
                                .Where(se => se.Year == Year && se.Subject.YearInCareer == YearInCareer && se.DeletedAt == null)
                                .GroupBy(se => new { se.Subject.Id, se.Subject.Name })
                                .Select(g => new { g.Key.Id, g.Key.Name })
                                .Distinct()
                                .Count();



                    return result;

                }
                catch (SqlException) { throw; }

            }
        }


        /// <summary>
        /// Retrieves the number of enrolments within a specific career and year.
        /// </summary>
        /// <param name="idCareer">The ID of the career.</param>
        /// <param name="Year">The enrolment year.</param>
        /// <returns>The count of enrolments for the specified career and year.</returns>
        public int getEnrolmentsByCareerByYear(int idCareer, int Year)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.CareerEnrolments
                        .Include(ce => ce.Career)
                        .Include(ce => ce.Student)
                        .ThenInclude(s => s.SubjectEnrolments)
                        .Where(ce => ce.CareerId == idCareer &&
                                     ce.Student.SubjectEnrolments.Any(se => se.Year == Year && se.DeletedAt == null))
                        .Count();

                    return result;

                }
                catch (SqlException) { throw; }

            }
        }


        /// <summary>
        /// Retrieves the count of students with academic delays in a specific subject for a given year.
        /// </summary>
        /// <param name="subjectId">The ID of the subject.</param>
        /// <param name="Year">The enrolment year.</param>
        /// <returns>The count of students with academic delays in the specified subject.</returns>
        public int getAcademicDelaysByCareerBySubject(int subjectId, int Year)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Students
                                .SelectMany(s => db.Users.Where(u => u.Id == s.UserId), (s, u) => new { s, u })
                                .SelectMany(su => db.CareerEnrolments.Where(ce => ce.StudentId == su.s.Id), (su, ce) => new { su.s, su.u, ce })
                                .SelectMany(suce => db.Careers.Where(c => c.Id == suce.ce.CareerId), (suce, c) => new { suce.s, suce.u, suce.ce, c })
                                .SelectMany(sucec => db.SubjectEnrolments.Where(se => se.StudentId == sucec.s.Id), (sucec, se) => new { sucec.s, sucec.u, sucec.ce, sucec.c, se })
                                .SelectMany(sucecs => db.Subjects.Where(sub => sub.Id == sucecs.se.SubjectId && sub.CareerId == sucecs.c.Id), (sucescs, sub) => new { sucescs.s, sucescs.u, sucescs.ce, sucescs.c, sucescs.se, sub })
                                .Where(sucesub =>
                                sucesub.se.Year > (sucesub.ce.YearOfRegistration + sucesub.sub.YearInCareer - 1) &&
                                sucesub.se.SubjectId == subjectId &&
                                sucesub.se.Year == Year &&
                                sucesub.sub.DeletedAt == null)
                                .Select(sucesub => new
                                {
                                    StudentId = sucesub.s.Id,
                                    Student = sucesub.u.LastName,
                                    CareerName = sucesub.c.Name,
                                    SubjectName = sucesub.sub.Name,
                                    YearOfRegistration = sucesub.ce.YearOfRegistration,
                                    SubjectEnrolmentYear = sucesub.se.Year,
                                    ExpectedYear = sucesub.ce.YearOfRegistration + sucesub.sub.YearInCareer - 1,
                                    AcademicDelay = sucesub.se.Year > (sucesub.ce.YearOfRegistration + sucesub.sub.YearInCareer - 1) ? "Atraso" : null
                                })
                                .Distinct()
                                .Count();
                    return result;

                }
                catch (SqlException) { throw; };
            }
        }

        /// <summary>
        /// Retrieves the total count of students with academic delays across all careers for a specific year.
        /// </summary>
        /// <param name="year">The enrolment year.</param>
        /// <returns>The total count of students with academic delays across all careers.</returns>
        public int getTotalAcademicDelaysByCareer(int year)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Students
                                .SelectMany(s => db.Users.Where(u => u.Id == s.UserId), (s, u) => new { s, u })
                                .SelectMany(su => db.CareerEnrolments.Where(ce => ce.StudentId == su.s.Id), (su, ce) => new { su.s, su.u, ce })
                                .SelectMany(suce => db.Careers.Where(c => c.Id == suce.ce.CareerId), (suce, c) => new { suce.s, suce.u, suce.ce, c })
                                .SelectMany(sucec => db.SubjectEnrolments.Where(se => se.StudentId == sucec.s.Id), (sucec, se) => new { sucec.s, sucec.u, sucec.ce, sucec.c, se })
                                .SelectMany(sucecs => db.Subjects.Where(sub => sub.Id == sucecs.se.SubjectId && sub.CareerId == sucecs.c.Id), (sucecs, sub) => new { sucecs.s, sucecs.u, sucecs.ce, sucecs.c, sucecs.se, sub })
                                .Where(sucesub =>
                                    sucesub.se.Year > (sucesub.ce.YearOfRegistration + sucesub.sub.YearInCareer - 1) &&
                                    sucesub.se.Year == year &&
                                    sucesub.sub.DeletedAt == null)
                                .Select(sucesub => sucesub.s.Id)
                                .Distinct()
                                .Count();

                    return result;
                }
                catch (SqlException) { throw; }
            }
        }

        /// <summary>
        /// Retrieves the total count of students with academic delays across all courses (years in career) for a specific year.
        /// </summary>
        /// <param name="year">The enrolment year.</param>
        /// <returns>The total count of students with academic delays across all courses.</returns>
        public int getTotalAcademicDelaysByCourse(int year)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Students
                                .SelectMany(s => db.Users.Where(u => u.Id == s.UserId), (s, u) => new { s, u })
                                .SelectMany(su => db.CareerEnrolments.Where(ce => ce.StudentId == su.s.Id), (su, ce) => new { su.s, su.u, ce })
                                .SelectMany(suce => db.Careers.Where(c => c.Id == suce.ce.CareerId), (suce, c) => new { suce.s, suce.u, suce.ce, c })
                                .SelectMany(sucec => db.SubjectEnrolments.Where(se => se.StudentId == sucec.s.Id), (sucec, se) => new { sucec.s, sucec.u, sucec.ce, sucec.c, se })
                                .SelectMany(sucecs => db.Subjects.Where(sub => sub.Id == sucecs.se.SubjectId && sub.CareerId == sucecs.c.Id), (sucecs, sub) => new { sucecs.s, sucecs.u, sucecs.ce, sucecs.c, sucecs.se, sub })
                                .Where(sucesub =>
                                    sucesub.se.Year > (sucesub.ce.YearOfRegistration + sucesub.sub.YearInCareer - 1) &&
                                    sucesub.se.Year == year &&
                                    sucesub.sub.DeletedAt == null)
                                .Select(sucesub => sucesub.s.Id)
                                .Distinct()
                                .Count();

                    return result;
                }
                catch (SqlException) { throw; }
            }
        }


        /// <summary>
        /// Retrieves the count of students without academic delays in a specific subject for a given year.
        /// </summary>
        /// <param name="subjectId">The ID of the subject.</param>
        /// <param name="Year">The enrolment year.</param>
        /// <returns>The count of students without academic delays in the specified subject.</returns>
        public int getNotAcademicDelaysByCareerBySubject(int subjectId, int Year)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Students
                                    .SelectMany(s => db.Users.Where(u => u.Id == s.UserId), (s, u) => new { s, u })
                                    .SelectMany(su => db.CareerEnrolments.Where(ce => ce.StudentId == su.s.Id), (su, ce) => new { su.s, su.u, ce })
                                    .SelectMany(suce => db.Careers.Where(c => c.Id == suce.ce.CareerId), (suce, c) => new { suce.s, suce.u, suce.ce, c })
                                    .SelectMany(sucec => db.SubjectEnrolments.Where(se => se.StudentId == sucec.s.Id), (sucec, se) => new { sucec.s, sucec.u, sucec.ce, sucec.c, se })
                                    .SelectMany(sucecs => db.Subjects.Where(sub => sub.Id == sucecs.se.SubjectId && sub.CareerId == sucecs.c.Id), (sucescs, sub) => new { sucescs.s, sucescs.u, sucescs.ce, sucescs.c, sucescs.se, sub })
                                    .Where(sucesub =>
                                        sucesub.se.Year <= (sucesub.ce.YearOfRegistration + sucesub.sub.YearInCareer - 1) &&
                                        sucesub.se.SubjectId == subjectId &&
                                        sucesub.se.Year == Year &&
                                        sucesub.sub.DeletedAt == null)
                                    .Select(sucesub => new
                                    {
                                        StudentId = sucesub.s.Id,
                                        Student = sucesub.u.LastName,
                                        CareerName = sucesub.c.Name,
                                        SubjectName = sucesub.sub.Name,
                                        YearOfRegistration = sucesub.ce.YearOfRegistration,
                                        SubjectEnrolmentYear = sucesub.se.Year,
                                        ExpectedYear = sucesub.ce.YearOfRegistration + sucesub.sub.YearInCareer - 1
                                    })
                                    .Distinct()
                                    .Count();

                    return result;

                }
                catch (SqlException) { throw; };
            }
        }

        /// <summary>
        /// Gets the count of students who re-enrolled in a specified subject and year within a career.
        /// </summary>
        /// <param name="subjectId">The ID of the subject.</param>
        /// <param name="year">The year for which to check re-enrollment.</param>
        /// <returns>The count of recurrent students.</returns>
        public int getRecurrentStudentsBySubjectAndYearInCareer(int subjectId, int year)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Students
                                   .SelectMany(s => db.Users.Where(u => u.Id == s.UserId), (s, u) => new { s, u })
                                   .SelectMany(su => db.SubjectEnrolments.Where(se1 => se1.StudentId == su.s.Id), (su, se1) => new { su.s, su.u, se1 })
                                   .SelectMany(suse1 => db.Subjects.Where(sub => sub.Id == suse1.se1.SubjectId), (suse1, sub) => new { suse1.s, suse1.u, suse1.se1, sub })
                                   .SelectMany(susesub => db.Careers.Where(c => c.Id == susesub.sub.CareerId), (susesub, c) => new { susesub.s, susesub.u, susesub.se1, susesub.sub, c })
                                   .SelectMany(susesubc => db.SubjectEnrolments.Where(se2 => se2.StudentId == susesubc.s.Id), (susesubc, se2) => new { susesubc.s, susesubc.u, susesubc.se1, susesubc.sub, susesubc.c, se2 })
                                   .Where(susesubcse2 =>
                                        susesubcse2.se1.SubjectId == susesubcse2.se2.SubjectId &&
                                        susesubcse2.se1.Year < susesubcse2.se2.Year &&
                                        susesubcse2.se1.Approved == false &&
                                        susesubcse2.sub.DeletedAt == null &&
                                        susesubcse2.se1.SubjectId == subjectId &&
                                        susesubcse2.se2.Year == year)
                                   .Select(susesubcse2 => new
                                   {
                                       StudentId = susesubcse2.s.Id,
                                       Student = susesubcse2.u.LastName,
                                       CareerName = susesubcse2.c.Name,
                                       YearInCareer = susesubcse2.sub.YearInCareer,
                                       YearOfSubjectEnrolment = susesubcse2.se2.Year,
                                       FirstYearOfEnrolment = susesubcse2.se1.Year
                                   })
                                   .Distinct()
                                   .Count();

                    return result;
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Gets the total count of recurrent students across all subjects and years.
        /// </summary>
        /// <returns>The total count of recurrent students.</returns>
        public int getTotalRecurrentStudents()
        {
            using (var db = new Context())
            {
                try
                {
                    var recurrentStudentCount = db.Students
                        .Join(db.SubjectEnrolments, student => student.Id, enrolment => enrolment.StudentId, (student, enrolment) => new { student, enrolment })
                        .Where(joined => !joined.enrolment.Approved)
                        .GroupBy(j => j.student.Id)
                        .Count();

                    return recurrentStudentCount;
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Gets the total count of recurrent students across all careers for a specific year.
        /// </summary>
        /// <param name="year">The year to filter re-enrollment data.</param>
        /// <returns>The total count of recurrent students.</returns>
        public int getTotalRecurrentStudentsByYear(int year)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Students
                                   .SelectMany(s => db.Users.Where(u => u.Id == s.UserId), (s, u) => new { s, u })
                                   .SelectMany(su => db.SubjectEnrolments.Where(se1 => se1.StudentId == su.s.Id), (su, se1) => new { su.s, su.u, se1 })
                                   .SelectMany(suse1 => db.Subjects.Where(sub => sub.Id == suse1.se1.SubjectId), (suse1, sub) => new { suse1.s, suse1.u, suse1.se1, sub })
                                   .SelectMany(susesub => db.Careers.Where(c => c.Id == susesub.sub.CareerId), (susesub, c) => new { susesub.s, susesub.u, susesub.se1, susesub.sub, c })
                                   .SelectMany(susesubc => db.SubjectEnrolments.Where(se2 => se2.StudentId == susesubc.s.Id), (susesubc, se2) => new { susesubc.s, susesubc.u, susesubc.se1, susesubc.sub, susesubc.c, se2 })
                                   .Where(susesubcse2 =>
                                        susesubcse2.se1.SubjectId == susesubcse2.se2.SubjectId &&
                                        susesubcse2.se1.Year < susesubcse2.se2.Year &&
                                        susesubcse2.se1.Approved == false &&
                                        susesubcse2.sub.DeletedAt == null &&
                                        susesubcse2.se2.Year == year)
                                   .Select(susesubcse2 => susesubcse2.s.Id)
                                   .Distinct()
                                   .Count();

                    return result;
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }
    }
}
