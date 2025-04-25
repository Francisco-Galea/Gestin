using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Model.Dao
{
    public class ScheduleDao
    {
        CareerDao careerDao = new CareerDao();
        public ScheduleDao() { }

        #region Loaders

        /// <summary>
        /// Loads all schedules from the database, including their associated subjects.
        /// </summary>
        /// <returns>A list of all schedules.</returns>
        public List<Schedule> loadSchedules()
        {
            try
            {
                using (var db = new Context())
                {
                    var result = db.Schedules.Include(x => x.Subject).ToList();
                    return result;
                }
            }
            catch (SqlException) { throw; }
        }

        #endregion

        #region Schedule

        /// <summary>
        /// Counts the total number of schedules in the database.
        /// </summary>
        /// <returns>The count of schedules.</returns>
        public int countSchedules()
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Schedules.Count();
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Finds a schedule by the given subject year, time, and day.
        /// </summary>
        /// <param name="time">The starting time of the schedule.</param>
        /// <param name="day">The day of the week the schedule occurs.</param>
        /// <param name="year">The year of the subject in the career.</param>
        /// <param name="subjectID">The ID of the subject.</param>
        /// <returns>The found schedule.</returns>
        public Schedule findScheduleBySubjectYear(TimeSpan time, string day, int year, int subjectID)
        {
            using (var db = new Context())
            {
                return db.Schedules
                    .Where(x => x.Subject.Id == subjectID && x.Day == day && x.StartingTime == time && x.Subject.YearInCareer == year)
                    .First();
            }
        }

        /// <summary>
        /// Gets a list of schedules for the specified subject.
        /// </summary>
        /// <param name="subject">The subject to retrieve schedules for.</param>
        /// <returns>A list of schedules for the subject.</returns>
        public List<Schedule> getSubjectSchedules(Subject subject)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.Schedules.Where(x => x.Subject == subject).ToList();
                }
                catch (SqlException) { throw; }
            }
        }

        /// <summary>
        /// Gets the schedules for subjects in a specified career and year.
        /// </summary>
        /// <param name="career">The career object to get subjects from.</param>
        /// <param name="subjectYear">The year of the subjects in the career.</param>
        /// <returns>A list of schedules in the career for the specified year.</returns>
        public List<Schedule> getSchedulesInCareerByYear(object career, int subjectYear)
        {
            List<Subject> careerSubjects = careerDao.loadSubjectsFromCareer((Career)career);

            List<Schedule> schedulesInCareer = loadSchedules()
                .Where(sch => careerSubjects
                .Any(sub => sch.SubjectId == sub.Id && sch.Subject.YearInCareer == subjectYear))
                .ToList();

            return schedulesInCareer;
        }

        /// <summary>
        /// Gets the schedule for a specific teacher subject.
        /// </summary>
        /// <param name="teacher">The teacher subject to find the schedule for.</param>
        /// <returns>A list of schedules for the teacher subject.</returns>
        public List<Schedule> getTeacherSchedule(TeacherSubject teacher)
        {
            try
            {
                using (var db = new Context())
                {
                    var result = db.Schedules.Where(x => x.SubjectId == teacher.SubjectId).ToList();
                    return result;
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Checks if a schedule is active at a specific time for a subject year.
        /// </summary>
        /// <param name="time">The starting time of the schedule.</param>
        /// <param name="day">The day of the week the schedule occurs.</param>
        /// <param name="subjectYear">The year of the subject in the career.</param>
        /// <param name="subjectId">The ID of the subject to check.</param>
        /// <returns>True if the schedule is active; otherwise, false.</returns>
        public bool IsScheduleActiveAtTimeForYear(TimeSpan time, string day, int subjectYear, int subjectId)
        {
            try
            {
                using (var db = new Context())
                {
                    var schedule = db.Schedules
                        .Where(x => x.StartingTime == time && x.Day == day && x.Subject.YearInCareer == subjectYear && x.SubjectId == subjectId)
                        .FirstOrDefault();

                    return schedule != null;
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }

        }

        /// <summary>
        /// Deletes a schedule for a specified subject based on time, day, and year.
        /// </summary>
        /// <param name="time">The starting time of the schedule.</param>
        /// <param name="day">The day of the week the schedule occurs.</param>
        /// <param name="subjectYear">The year of the subject in the career.</param>
        /// <param name="subjectID">The ID of the subject to delete the schedule for.</param>
        public void deleteScheduleForSpecifiedSubject(TimeSpan time, string day, int subjectYear, int subjectID)
        {
            Schedule existingSchedule = findScheduleBySubjectYear(time, day, subjectYear, subjectID);

            try
            {
                using (var db = new Context())
                {
                    db.Remove(existingSchedule);
                    db.SaveChanges();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }


        /// <summary>
        /// Saves the specified schedule entity to the database.
        /// </summary>
        /// <param name="schedule">The schedule entity to save.</param>
        public void saveSchedule(Schedule schedule)
        {
            try
            {
                using (var db = new Context())
                {
                    db.Schedules.Add(schedule);
                    db.SaveChanges();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the updated schedule to the database.
        /// </summary>
        /// <param name="schedule">The Schedule object to be saved.</param>
        public void saveUpdatedSchedule(Schedule schedule)
        {
            try
            {
                using (var db = new Context())
                {
                    db.Update(schedule);
                    db.SaveChanges();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }
        #endregion
    }
}
