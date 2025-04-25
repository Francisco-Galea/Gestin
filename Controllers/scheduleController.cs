using Gestin.Model;
using Gestin.Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Controllers
{
    internal class scheduleController
    {
        sessionController sessionController = sessionController.getInstance();
        subjectController subjectController = subjectController.getInstance();
        careerController? careerController;
        ScheduleDao scheduleDao = new ScheduleDao();

        #region Singletone

        private static scheduleController? Instance;

        private scheduleController() { }

        public static scheduleController getInstance()
        {
            if (Instance == null)
            {
                Instance = new scheduleController();
            }
            return Instance;
        }
        #endregion

        #region Loaders

        public List<Schedule> loadSchedules()
        {
            return scheduleDao.loadSchedules();
        }

        #endregion

        #region Schedule

        public int countSchedules()
        {
            return scheduleDao.countSchedules();
        }

        public Schedule findScheduleBySubjectYear(TimeSpan time, string day, int year, int subjectID)
        {
            return scheduleDao.findScheduleBySubjectYear(time, day, year, subjectID);
        }

        public List<Schedule> getSubjectSchedules(Subject subject) // 1 modulo = 1 hora || Dia y Hora de la materia
        {
            return scheduleDao.getSubjectSchedules(subject);
        }

        /// <summary>
        /// Retrieves a list of teacher schedule values formatted as lists of strings for the specified list of schedules.
        /// </summary>
        /// <param name="schedules">The list of schedules to retrieve teacher schedule values from.</param>
        /// <returns>A list of lists containing string values representing details of each schedule.</returns>
        public List<List<string?>> getTeacherScheduleValues(List<Schedule> schedules)
        {
            var moduleMatrix = new List<List<string?>>();

            foreach (var module in schedules)
            {
                var moduleValues = getModuleValues(module);
                moduleMatrix.Add(moduleValues);
            }

            return moduleMatrix;
        }

        /// <summary>
        /// Retrieves string values for a specific schedule module, including subject name, starting time, and day.
        /// </summary>
        /// <param name="module">The schedule module to retrieve values from.</param>
        /// <returns>A list of strings representing the values of the specified schedule module.</returns>
        public List<string?> getModuleValues(Schedule module)
        {
            var subject = subjectController.findSubject(module.SubjectId);
            return new List<string?>
            {
                subject?.Name,
                Convert.ToString(module.StartingTime),
                module.Day
            };
        }

        public List<Schedule> getTeacherSchedule(TeacherSubject teacher)
        {
            return scheduleDao.getTeacherSchedule(teacher);
        }

        public List<Schedule> getSchedulesInCareerByYear(object career, int subjectYear)
        {
            return scheduleDao.getSchedulesInCareerByYear(career, subjectYear);
        }

        /// <summary>
        /// Retrieves a list of schedule values formatted as lists of strings, for the specified list of schedules.
        /// </summary>
        /// <param name="schedulesByCareerYear">The list of schedules to retrieve values from.</param>
        /// <returns>A list of lists containing string values representing schedule details.</returns>
        public List<List<string?>> getScheduleValues(List<Schedule> schedulesByCareerYear)
        {
            var moduleMatrix = new List<List<string?>>();

            foreach (var module in schedulesByCareerYear)
            {
                var moduleValues = getModuleValues(module);
                moduleMatrix.Add(moduleValues);
            }

            return moduleMatrix;
        }

        public void assignScheduleForSpecifiedSubject(TimeSpan time, string day, int subjectYear, int subjectID)
        {
            if (!IsScheduleActiveAtTimeForYear(time, day, subjectYear, subjectID))
            {
                createSchedule(time, day, subjectID);
            }
            else
            {
                modifySchedule(time, day, subjectID, subjectYear);
            }
        }

        /// <summary>
        /// Creates a new schedule with the specified time, day, and subject ID, then saves it to the database.
        /// </summary>
        /// <param name="time">The starting time of the schedule.</param>
        /// <param name="day">The day of the schedule.</param>
        /// <param name="subjectID">The ID of the subject associated with the schedule.</param>
        public void createSchedule(TimeSpan time, string day, int subjectID)
        {
            var schedule = createScheduleEntity(time, day, subjectID);
            saveSchedule(schedule);
        }

        /// <summary>
        /// Creates a new schedule entity with the specified attributes.
        /// </summary>
        /// <param name="time">The starting time of the schedule.</param>
        /// <param name="day">The day of the schedule.</param>
        /// <param name="subjectID">The ID of the subject associated with the schedule.</param>
        /// <returns>A new instance of <see cref="Schedule"/> with the specified attributes.</returns>
        private Schedule createScheduleEntity(TimeSpan time, string day, int subjectID)
        {
            return new Schedule
            {
                StartingTime = time,
                Day = day,
                SubjectId = subjectID,
                CreatedAt = DateTime.Now,
                LastModificationBy = sessionController.getSessionedUserData()
            };
        }

        private void saveSchedule(Schedule schedule)
        {
            scheduleDao.saveSchedule(schedule);
        }

        /// <summary>
        /// Modifies the schedule for a specific subject.
        /// </summary>
        /// <param name="time">The new starting time for the subject.</param>
        /// <param name="day">The day of the week when the subject is taught.</param>
        /// <param name="subjectID">The unique identifier of the subject.</param>
        /// <param name="subjectYear">The academic year of the subject.</param>
        public void modifySchedule(TimeSpan time, string day, int subjectID, int subjectYear)
        {
            var updatedSchedule = findScheduleBySubjectYear(time, day, subjectYear, subjectID);
            if (updatedSchedule != null)
            {
                updateScheduleDetails(updatedSchedule, time, day, subjectID);
                saveUpdatedSchedule(updatedSchedule);
            }
        }

        /// <summary>
        /// Updates the details of the schedule.
        /// </summary>
        /// <param name="schedule">The Schedule object to be updated.</param>
        /// <param name="time">The new starting time.</param>
        /// <param name="day">The new day of the week.</param>
        /// <param name="subjectID">The identifier of the associated subject.</param>
        private void updateScheduleDetails(Schedule schedule, TimeSpan time, string day, int subjectID)
        {
            schedule.StartingTime = time;
            schedule.Day = day;
            schedule.SubjectId = subjectID;
            schedule.UpdatedAt = DateTime.Now;
            schedule.LastModificationBy = sessionController.getSessionedUserData();
        }

        private void saveUpdatedSchedule(Schedule schedule)
        {
            scheduleDao.saveUpdatedSchedule(schedule);
        }

        public bool IsSubjectWeeklyHoursExceeded(int hourCount, int subjectID)
        {
            int weeklyHours = subjectController.getWeeklyHoursFromSubject(subjectID);
            return hourCount > weeklyHours;
        }

        public bool IsScheduleActiveAtTimeForYear(TimeSpan time, string day, int subjectYear, int subjectId)
        {
            return scheduleDao.IsScheduleActiveAtTimeForYear(time, day, subjectYear, subjectId);

        }

        public void deleteScheduleForSpecifiedSubject(TimeSpan time, string day, int subjectYear, int subjectID)
        {
            scheduleDao.deleteScheduleForSpecifiedSubject(time, day, subjectYear, subjectID);
        }

        /// <summary>
        /// Converts a list of time strings into a list of <see cref="TimeSpan"/> objects.
        /// </summary>
        /// <param name="timeList">A list of time strings in "hh:mm" format.</param>
        /// <returns>A list of <see cref="TimeSpan"/> objects corresponding to the input times.</returns>
        public List<TimeSpan> rowHeaderStringListToTimeSpanList(List<string> timeList) //unused deprecated
        {
            List<TimeSpan> correctedList = new List<TimeSpan>();
            foreach (string time in timeList)
            {
                correctedList.Add(TimeSpan.Parse(time.Split(" ")[0]));
            }
            return correctedList;
        }
        #endregion
    }
}
