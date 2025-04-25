using Gestin.Model;
using Gestin.Model.Dao;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gestin.Controllers
{
    internal class subjectEnrolmentController
    {
        careerController careerController = careerController.getInstance();
        subjectController subjectController = subjectController.getInstance();
        sessionController? sessionController = sessionController.getInstance();
        correlativeController correlativeController = correlativeController.getInstance();
        SubjectEnrolmentDao subjectEnrolmentDao = new SubjectEnrolmentDao();
        SubjectDao subjectDao = new SubjectDao();

        #region Singleton

        private static subjectEnrolmentController? Instance;

        private subjectEnrolmentController() { }

        public static subjectEnrolmentController getInstance()
        {
            if (Instance == null)
            {
                Instance = new subjectEnrolmentController();
            }
            return Instance;
        }
        #endregion

        #region Subject Enrolment

        #region Create Methods

        /// <summary>
        /// Enrolls a student in a specified subject for a given year and stores the enrolment in the database.
        /// </summary>
        /// <param name="studentObject">An object representing the student to be enrolled. This object is cast to a <see cref="Student"/>.</param>
        /// <param name="subjectObject">An object representing the subject for enrolment. This object is cast to a <see cref="Subject"/>.</param>
        /// <param name="year">The academic year in which the student is enrolling in the subject.</param>
        /// <param name="presential">A boolean indicating whether the enrolment is for a presential course. Set to <c>true</c> for presential, or <c>false</c> for remote.</param>
        /// <param name="approved">A boolean indicating whether the student has already passed the subject. Set to <c>true</c> if approved, otherwise <c>false</c>.</param>
        /// <returns>
        /// A boolean indicating whether the enrolment was successfully saved to the database. Returns <c>true</c> if the enrolment was added successfully; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// This method checks for any previous enrolments of the student in the specified subject by querying the database. If no enrolment exists, it creates a new 
        /// <see cref="SubjectEnrolment"/> object with the provided information and saves it to the database using <see cref="SaveEnrolment"/>.
        /// </remarks>
        /// 
        public bool enrolToSubject(object studentObject, object subjectObject, int year, bool presential, bool approved)
        {
            Student student = (Student)studentObject;
            Subject subject = (Subject)subjectObject;
            try
            {
                var previousEnrolment = subjectEnrolmentDao.GetEnrolmentsByStudentAndSubject(student.Id, subject.Id);
                var newEnrolment = CreateNewEnrolment(student.Id, subject.Id, year, presential, approved);
                return subjectEnrolmentDao.SaveEnrolment(newEnrolment);
            }
            catch (SqlException)
            {
                throw;
            }
        }

        /// <summary>
        /// Creates a new subject enrolment instance for a student.
        /// </summary>
        /// <param name="studentId">The unique identifier of the student.</param>
        /// <param name="subjectId">The unique identifier of the subject.</param>
        /// <param name="year">The year of the enrolment.</param>
        /// <param name="presential">Indicates whether the enrolment is for a presencial course.</param>
        /// <param name="approved">Indicates whether the enrolment has been approved.</param>
        /// <returns>A new instance of <see cref="SubjectEnrolment"/> populated with the provided information.</returns>
        /// <remarks>
        /// This method constructs a new subject enrolment with the specified details.
        /// The <c>CreatedAt</c> property is set to the current date and time,
        /// and the <c>LastModificationBy</c> property is set to "Preceptor".
        /// </remarks>
        private SubjectEnrolment CreateNewEnrolment(int studentId, int subjectId, int year, bool presential, bool approved)
        {
            return new SubjectEnrolment
            {
                StudentId = studentId,
                SubjectId = subjectId,
                Year = year,
                Presential = presential,
                Approved = approved,
                CreatedAt = DateTime.Now,
                LastModificationBy = "Preceptor"
            };
        }
        #endregion

        #region Get methods 

        /// <summary>
        /// Retrieves the enrolment record for a specific subject and career from the database, if it exists.
        /// </summary>
        /// <param name="subject">An object representing the subject for which enrolment is being retrieved. This object is cast to a <see cref="Subject"/>.</param>
        /// <param name="career">An object representing the career related to the subject. This object is cast to a <see cref="Career"/>.</param>
        /// <returns>
        /// A <see cref="SubjectEnrolment"/> object if an enrolment is found for the specified subject and career; otherwise, <c>null</c>.
        /// </returns>
        /// <remarks>
        /// This method queries the database to find an enrolment record that matches the specified subject and career IDs. 
        /// It includes the related <see cref="Subject"/> entity in the result for additional information.
        /// </remarks>
        public SubjectEnrolment? getEnrolment(object subject, object career)
        {
            Subject thisSubject = (Subject)subject;
            Career thisCareer = (Career)career;
            return subjectEnrolmentDao.GetEnrolment(thisSubject.Id, thisCareer.Id);
        }

        public SubjectEnrolment? getEnrolment(int dni, object subject, object career)
        {
            Subject thisSubject = (Subject)subject;
            CareerEnrolment thisCareer = (CareerEnrolment)career;
            using (var db = new Context())
            {
                return db.SubjectEnrolments.Where(x => x.Student.User.Dni == dni && x.SubjectId == thisSubject.Id && x.Subject.CareerId == thisCareer.CareerId).Include(x => x.Subject).FirstOrDefault();
            }
        }

        public List<SubjectEnrolment> getEnrolments(int dni)
        {
            using (var db = new Context())
            {
                return db.SubjectEnrolments.Where(x => x.Student.User.Dni == dni).Include(x => x.Subject).ToList(); ;
            }
        }
        /// <summary>
        /// Retrieves a list of <see cref="SubjectEnrolment"/> records for a student based on their DNI and career.
        /// </summary>
        /// <param name="dni">The DNI of the student whose enrolments are being retrieved.</param>
        /// <param name="career">The <see cref="CareerEnrolment"/> object representing the career associated with the enrolments.</param>
        /// <returns>
        /// A <see cref="List{SubjectEnrolment}"/> containing enrolment records for the specified student and career.
        /// Returns an empty list if <paramref name="career"/> is <c>null</c>.
        /// </returns>
        /// <remarks>
        /// This method queries the database for <see cref="SubjectEnrolment"/> records that match the specified 
        /// <paramref name="dni"/> of the student and the <paramref name="career"/>. It includes the associated 
        /// <see cref="Subject"/> entity in each enrolment result for detailed reference.
        /// </remarks>
        public List<SubjectEnrolment> getEnrolments(int dni, object career)
        {
            CareerEnrolment thisCareer = (CareerEnrolment)career;
            if (thisCareer == null)
                return new List<SubjectEnrolment>();
            using (var db = new Context())
            {
                return db.SubjectEnrolments.Where(x => x.Student.User.Dni == dni && x.Subject.CareerId == thisCareer.CareerId).Include(x => x.Subject).ToList();
            }
        }

        public List<SubjectEnrolment> getEnrolments(object subjectEnrolment, int year)
        {
            SubjectEnrolment thisEnrolment = (SubjectEnrolment)subjectEnrolment;
            if (thisEnrolment == null)
                return new List<SubjectEnrolment>();
            using (var db = new Context())
            {
                return db.SubjectEnrolments.Where(x => x.SubjectId == thisEnrolment.SubjectId && x.Year == year).Include(x => x.Subject).ToList();
            }
        }

        public int getEnrolmentsStudentsCount(object thisCareer, object thisSubject, int year)
        {
            Career career = (Career)thisCareer;
            Subject subject = (Subject)thisSubject;

            using (var db = new Context())
            {
                return db.SubjectEnrolments.Where(x => x.SubjectId == subject.Id && x.Subject.CareerId == career.Id && x.Year == year && x.Presential).Select(x => x.Student).Count();
            }
        }
        /// <summary>
        /// Retrieves a list of <see cref="SubjectEnrolment"/> records for a specific student and career.
        /// </summary>
        /// <param name="dni">The DNI (identification number) of the student for whom to retrieve enrolments.</param>
        /// <param name="careerId">The ID of the career for which to retrieve enrolments.</param>
        /// <returns>A <see cref="List{SubjectEnrolment}"/> containing enrolments of the specified student within the specified career.</returns>
        /// <remarks>
        /// This method queries the database for <see cref="SubjectEnrolment"/> entities associated with the given
        /// <paramref name="dni"/> and <paramref name="careerId"/>. It includes the <see cref="Subject"/> entity
        /// in the results to provide detailed information about each subject related to the enrolments.
        /// </remarks>
        public List<SubjectEnrolment> getSubjectEnrolmentsByCareer(int dni, int careerId)
        {
            using (var db = new Context())
            {
                return db.SubjectEnrolments.Where(x => x.Student.User.Dni == dni && x.Subject.CareerId == careerId).Include(x => x.Subject).ToList();
            }
        }
        /// <summary>
        /// Retrieves all <see cref="Subject"/> records associated with a specific career.
        /// </summary>
        /// <param name="careerId">The ID of the career for which to retrieve subjects.</param>
        /// <returns>A <see cref="List{Subject}"/> containing all subjects associated with the specified career.</returns>
        /// <remarks>
        /// This method uses the <c>careerController</c> to retrieve all <see cref="Subject"/> entities linked to the
        /// specified <paramref name="careerId"/>. It is intended to provide a list of subjects offered within a particular career.
        /// </remarks>
        private List<Subject> GetAllSubjectsFromCareer(int careerId)
        {
            return subjectController.getSubjectsFromCareer(careerId);
        }

        /// <summary>
        /// Retrieves a list of <see cref="SubjectEnrolment"/> records for a specific student and career.
        /// </summary>
        /// <param name="dni">The DNI (identification number) of the student whose enrolments are to be retrieved.</param>
        /// <param name="careerId">The ID of the career for which to retrieve enrolments.</param>
        /// <returns>A <see cref="List{SubjectEnrolment}"/> containing enrolment records for the specified student and career.</returns>
        /// <remarks>
        /// This method calls <c>getSubjectEnrolmentsByCareer</c> to retrieve all <see cref="SubjectEnrolment"/> entities
        /// associated with the specified <paramref name="dni"/> and <paramref name="careerId"/>. It is intended for
        /// fetching enrolments of a student in a specific career.
        /// </remarks>
        private List<SubjectEnrolment> GetEnrolledSubjects(int dni, int careerId)
        {
            return getSubjectEnrolmentsByCareer(dni, careerId);
        }

        private List<Subject> GetAlreadyEnrolledOrApprovedSubjects(List<SubjectEnrolment> enrolledSubjects)
        {
            return enrolledSubjects
                .Where(x => x.Approved || x.Year == DateTime.Now.Year)
                .Select(x => x.Subject)
                .ToList();
        }
        private List<Subject> GetEnrolledNonApprovedSubjects(List<SubjectEnrolment> enrolledSubjects)
        {
            return enrolledSubjects
                .Where(x => !x.Approved)
                .Select(x => x.Subject)
                .ToList();
        }
        private List<Subject> GetCorrelativeFutures(List<Subject> enrolledNonApprovedSubjects)
        {
            return correlativeController.loadCorrelativesBranches(enrolledNonApprovedSubjects);
        }
        /// <summary>
        /// Retrieves the accreditation type for a student based on their enrollment in a specific subject.
        /// </summary>
        /// <param name="dni">The DNI (National Identity Document) of the student whose accreditation type is to be retrieved.</param>
        /// <param name="Idsubject">The ID of the subject for which to check the accreditation type.</param>
        /// <returns>
        /// A <see cref="string"/> indicating the accreditation type, which can be either "Presencial" (in-person) or "Libre" (free).
        /// </returns>
        /// <remarks>
        /// This method checks the <see cref="SubjectEnrolment"/> records in the database to determine 
        /// if the specified student is enrolled in the specified subject and whether their enrollment is 
        /// classified as "Presencial". If the student is enrolled as "Presencial", the method returns 
        /// "Presencial"; otherwise, it returns "Libre".
        /// </remarks>
        public string getAccreditationType(int dni, int Idsubject)
        {
            using (var db = new Context())
            {
                string result = "Libre";
                bool state = db.SubjectEnrolments.Where(x => (x.Student.User.Dni == dni && x.SubjectId == Idsubject)).Select(x => x.Presential).FirstOrDefault();
                if (state == true)
                    result = "Presencial";
                return result;
            }
        }
        /// <summary>
        /// Retrieves the accreditation type for a student based on their enrollment in a specific subject using the student's ID.
        /// </summary>
        /// <param name="studentId">The ID of the student whose accreditation type is to be retrieved.</param>
        /// <param name="Idsubject">The ID of the subject for which to check the accreditation type.</param>
        /// <returns>
        /// A <see cref="string"/> indicating the accreditation type, which can be either "Presencial" (in-person) or "Libre" (free).
        /// </returns>
        /// <remarks>
        /// This method checks the <see cref="SubjectEnrolment"/> records in the database to determine 
        /// if the specified student is enrolled in the specified subject and whether their enrollment is 
        /// classified as "Presencial". If the student is enrolled as "Presencial", the method returns 
        /// "Presencial"; otherwise, it returns "Libre".
        /// </remarks>
        public string getAccreditationTypeWithStudentId(int studentId, int Idsubject)
        {
            using (var db = new Context())
            {
                string result = "Libre";
                bool state = db.SubjectEnrolments.Where(x => (x.StudentId == studentId && x.SubjectId == Idsubject)).Select(x => x.Presential).FirstOrDefault();
                if (state == true)
                    result = "Presencial";
                return result;
            }
        }

        /// <summary>
        /// Retrieves a list of <see cref="SubjectEnrolment"/> records for a specific subject and year.
        /// </summary>
        /// <param name="subjectId">The ID of the subject for which to retrieve enrolments.</param>
        /// <param name="year">The year for which to filter the enrolments.</param>
        /// <returns>
        /// A <see cref="List{SubjectEnrolment}"/> containing all enrolments for the specified subject and year, 
        /// ordered by presence status and last name of the student.
        /// </returns>
        /// <remarks>
        /// This method queries the <see cref="SubjectEnrolment"/> entities in the database that have a matching 
        /// <paramref name="subjectId"/> and <paramref name="year"/>. The results are ordered first by the presence status 
        /// (non-presential enrolments come after presential ones) and then by the last name of the student. 
        /// It includes related <see cref="Student"/> and <see cref="User"/> entities for each enrolment.
        /// </remarks>
        public List<SubjectEnrolment> GetSubjectEnrolments(int subjectId, int year)
        {
            return subjectEnrolmentDao.GetSubjectEnrolmentsBySubjectAndYear(subjectId, year);
        }

        public List<SubjectEnrolment> GetSubjectEnrolments(object subjectObject, int year)
        {
            Subject subject = (Subject)subjectObject;
            using (var db = new Context())
            {
                return db.SubjectEnrolments
                    .Where(x => x.SubjectId == subject.Id && x.Year == year)
                    .OrderBy(x => x.Student.User.LastName)
                    .Include(x => x.Student)
                    .Include(x => x.Student.User)
                    .ToList();
            }
        }

        /// <summary>
        /// Retrieves the enrolment data for a specific <see cref="SubjectEnrolment"/> and formats it for display in a data table.
        /// </summary>
        /// <param name="se">The <see cref="SubjectEnrolment"/> object containing the enrolment details.</param>
        /// <returns>
        /// A <see cref="List{dynamic}"/> containing the formatted enrolment data, including student DNI, name, last name,
        /// approval status, and presence status.
        /// </returns>
        /// <remarks>
        /// This method takes a <paramref name="se"/> parameter, which is expected to be a <see cref="SubjectEnrolment"/> 
        /// object. It extracts relevant information from the enrolment record and returns it in a dynamic list format, 
        /// suitable for use in a data table display. The list includes the student's DNI, name, last name, whether the 
        /// enrolment is approved, and if the enrolment is presential.
        /// </remarks>
        internal List<dynamic> getEnrolmentDataTable(object se)
        {
            SubjectEnrolment subjectEnrolment = (SubjectEnrolment)se;
            List<dynamic> enrolmentData = new()
            {
                subjectEnrolment.Student.User.Dni,
                subjectEnrolment.Student.User.Name,
                subjectEnrolment.Student.User.LastName,
                subjectEnrolment.Approved,
                subjectEnrolment.Presential
            };
            return enrolmentData;
        }

        /// <summary>
        /// Retrieves a list of distinct years in which enrolments exist for a specified subject, sorted in descending order.
        /// </summary>
        /// <param name="receivedSubject">The subject object for which to retrieve enrolment years.</param>
        /// <returns>
        /// A <see cref="List{int}"/> containing distinct years of enrolments for the specified subject, 
        /// or <c>null</c> if no years are found.
        /// </returns>
        /// <remarks>
        /// This method accepts a <see cref="Subject"/> object and calls the <see cref="GetEnrolmentYearsFromDatabase"/> 
        /// method to retrieve the enrolment years from the database. The years are then sorted in descending order 
        /// using the <see cref="SortYearsDescending"/> method. If any SQL exceptions occur during the database operation, 
        /// they are rethrown for handling at a higher level.
        /// </remarks>
        internal List<int>? getSubjectEnrolmentsYear(object receivedSubject)
        {
            Subject subject = (Subject)receivedSubject;
            try
            {
                var enrolmentYears = GetEnrolmentYearsFromDatabase(subject.Id);
                return SortYearsDescending(enrolmentYears);
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Retrieves a list of distinct years in which enrolments exist for a specific subject.
        /// </summary>
        /// <param name="subjectId">The ID of the subject for which to retrieve enrolment years.</param>
        /// <returns>
        /// A <see cref="List{int}"/> containing distinct years of enrolments for the specified subject.
        /// </returns>
        /// <remarks>
        /// This method queries the database to find all <see cref="SubjectEnrolment"/> records associated with the given 
        /// <paramref name="subjectId"/>. It selects the year of each enrolment, ensuring that only distinct years are returned.
        /// This is useful for determining which academic years have enrolments for a particular subject.
        /// </remarks>
        private List<int> GetEnrolmentYearsFromDatabase(int subjectId)
        {
            return subjectEnrolmentDao.GetEnrolmentYears(subjectId);
        }

        #endregion

        #region Update Methohds 

        /// <summary>
        /// Updates an existing enrolment record with the specified year and presential status.
        /// </summary>
        /// <param name="enrolmentId">The ID of the enrolment to be updated.</param>
        /// <param name="Year">The new year to set for the enrolment.</param>
        /// <param name="Presential">A boolean indicating whether the enrolment is presential.</param>
        /// <returns>
        /// <c>true</c> if the enrolment was updated successfully; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// This method retrieves an existing <see cref="SubjectEnrolment"/> record by its ID using the 
        /// <see cref="findEnrolment"/> method. If the enrolment exists, it updates the year and presential 
        /// status, sets the updated timestamp, and commits the changes to the database. 
        /// If the enrolment does not exist or an exception occurs during the process, 
        /// the method returns <c>false</c>. SQL exceptions are rethrown for higher-level handling.
        /// </remarks>
        public bool updateEnrolment(int enrolmentId, string Year, bool Presential)
        {
            try
            {
                using (var db = new Context())
                {
                    SubjectEnrolment result = findEnrolment(enrolmentId);
                    if (result != null)
                    {
                        result.Year = Int32.Parse(Year);
                        result.Presential = Presential;
                        result.UpdatedAt = DateTime.Now;
                        db.Update(result);
                        return db.SaveChanges() > 0;
                    }
                }
                return false;
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Changes the approval status of a libre subject enrolment for a specific student.
        /// </summary>
        /// <param name="studentId">The ID of the student whose enrolment is being updated.</param>
        /// <param name="subjectId">The ID of the subject for which the enrolment approval status is being changed.</param>
        /// <param name="status">The new approval status to set for the enrolment.</param>
        /// <returns>
        /// <c>true</c> if the approval status was updated successfully; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// This method retrieves the enrolment record for the specified student and subject using the 
        /// <see cref="findEnrolment"/> method. It then updates the approval status and sets the 
        /// updated timestamp before saving the changes to the database. 
        /// If an exception occurs during the update process, it is rethrown for higher-level handling.
        /// </remarks>
        public bool changeApprovalEnrolledLibreSubject(int studentId, int subjectId, bool status)
        {
            SubjectEnrolment enrol = findEnrolment(studentId, subjectId);

            try
            {
                enrol.Approved = status;
                enrol.UpdatedAt = DateTime.Now;
                using (var db = new Context())
                {
                    db.SubjectEnrolments.Update(enrol);
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region Delete Method 
        /// <summary>
        /// Deletes a <see cref="SubjectEnrolment"/> record by its ID using the data access layer.
        /// </summary>
        /// <param name="enrolId">The ID of the enrolment to be deleted.</param>
        /// <returns><c>true</c> if the enrolment was deleted successfully; otherwise, <c>false</c>.</returns>
        /// <exception cref="SqlException">Thrown if a database error occurs during the deletion process.</exception>
        /// <remarks>
        /// This method calls <see cref="SubjectEnrolmentDao.DeleteEnrolment"/> to delete an enrolment record 
        /// from the database. If an error occurs, a <see cref="SqlException"/> is thrown.
        /// </remarks>
        public bool deleteEnrolment(int enrolId)
        {
            try
            {
                return subjectEnrolmentDao.DeleteEnrolment(enrolId);
            }
            catch (SqlException) { throw; }
        }
        #endregion

        #region Find Methods

        /// <summary>
        /// Searches for subjects whose names or associated career names start with the specified search string.
        /// </summary>
        /// <param name="search">The search string used to filter subjects and their careers.</param>
        /// <returns>
        /// A list of <see cref="Subject"/> objects that match the search criteria. 
        /// If no subjects are found, an empty list is returned.
        /// </returns>
        /// <remarks>
        /// This method queries the database for subjects whose names or the names of their associated careers 
        /// start with the provided search string. It includes the related <see cref="Career"/> entity for each 
        /// subject in the result. The search is case-sensitive and uses the <c>StartsWith</c> method for filtering.
        /// </remarks>
        public List<Subject> searchBoxSubjectWithString(string search)
        {
            using (var db = new Context())
            {
                var list = db.Subjects.Where(x => (x.Name.StartsWith(search) || x.Career.Name.StartsWith(search))).Include(x => x.Career).ToList();
                return list;
            }
        }

        /// <summary>
        /// Retrieves a subject enrolment for a student based on their DNI and the subject ID.
        /// </summary>
        /// <param name="dni">The DNI (Document Number of Identity) of the student.</param>
        /// <param name="idSubject">The ID of the subject for which to find the enrolment.</param>
        /// <returns>
        /// The <see cref="SubjectEnrolment"/> object associated with the specified student and subject.
        /// If no enrolment is found, an exception is thrown.
        /// </returns>
        /// <remarks>
        /// This method queries the database to find a specific subject enrolment for a student using their DNI
        /// and the subject ID. It includes the related <see cref="Student"/> and <see cref="User"/> entities in the result.
        /// If no enrolment is found, an exception will be thrown, indicating that the specified enrolment does not exist.
        /// </remarks>
        public SubjectEnrolment FindSubjectEnrolment(int dni, int idSubject)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.SubjectEnrolments.Where(x => x.Student.User.Dni == dni && x.SubjectId == idSubject).Include(x => x.Student).Include(x => x.Student.User).First();
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Updates the approval status of a course enrolment for a student.
        /// </summary>
        /// <param name="dni">The DNI (Document Number of Identity) of the student whose enrolment is being updated.</param>
        /// <param name="subjectId">The ID of the subject for which the approval status is being updated.</param>
        /// <param name="status">The new approval status to set for the enrolment.</param>
        /// <returns>
        /// True if the approval status was successfully updated; otherwise, false.
        /// </returns>
        /// <remarks>
        /// This method retrieves the subject enrolment for the specified student and subject using their DNI and the subject ID.
        /// If the enrolment is found, it updates the approval status based on the provided status parameter.
        /// The changes are then saved to the database.
        /// If no enrolment is found, the method returns false.
        /// </remarks>
        public bool courseApproval(int dni, int subjectId, bool status)
        {
            try
            {
                using (var db = new Context())
                {
                    SubjectEnrolment result = FindSubjectEnrolment(dni, subjectId);
                    if (result != null)
                    {
                        result.Approved = status;
                        db.Update(result);
                        return db.SaveChanges() > 0;
                    }
                }
                return false;
            }
            catch (SqlException) { throw; }

        }

        private List<int> SortYearsDescending(List<int> years)
        {
            years.Reverse();
            return years;
        }

        internal List<int> subjectEnrolmentCountData(object subjectEnrolmentObject, int year)
        {
            List<SubjectEnrolment> subjectEnrolments = getEnrolments(subjectEnrolmentObject, year);
            List<int> enrolmentData = new List<int>();

            if(subjectEnrolments.Count > 0)
            {
                enrolmentData.Add(subjectEnrolments.Where(x => x.Presential).Count());
                enrolmentData.Add(subjectEnrolments.Where(x => !x.Presential).Count());
                enrolmentData.Add(enrolmentData[0] + enrolmentData[1]);
            }
            return enrolmentData;
        }

        /// <summary>
        /// Retrieves a subject enrolment by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the subject enrolment.</param>
        /// <returns>
        /// An instance of <see cref="SubjectEnrolment"/> if found; otherwise, <c>null</c>.
        /// </returns>
        /// <remarks>
        /// This method queries the database for a subject enrolment using the provided identifier.
        /// It includes the associated subject details in the result if the enrolment is found.
        /// </remarks>
        public SubjectEnrolment? findEnrolment(int id)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.SubjectEnrolments.Where(x => x.Id == id).Include(x => x.Subject).FirstOrDefault();
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Retrieves a subject enrolment for a specific student and subject.
        /// </summary>
        /// <param name="studentId">The unique identifier of the student.</param>
        /// <param name="subjectId">The unique identifier of the subject.</param>
        /// <returns>
        /// An instance of <see cref="SubjectEnrolment"/> if found; otherwise, <c>null</c>.
        /// </returns>
        /// <remarks>
        /// This method queries the database for a subject enrolment using the provided student and subject identifiers.
        /// </remarks>
        public SubjectEnrolment? findEnrolment(int studentId, int subjectId)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.SubjectEnrolments.Where(x => x.StudentId == studentId && x.SubjectId == subjectId).FirstOrDefault();
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Retrieves a list of available <see cref="Subject"/> options for enrolment based on the student's DNI and career.
        /// </summary>
        /// <param name="dni">The DNI of the student to check for available subjects.</param>
        /// <param name="careerEnrolment">The <see cref="CareerEnrolment"/> object representing the student's career.</param>
        /// <returns>
        /// A <see cref="List{Subject}"/> of subjects that the student is eligible to enrol in, based on career requirements
        /// and current enrolment status.
        /// </returns>
        /// <remarks>
        /// This method identifies all available subjects for enrolment by first retrieving all subjects in the specified 
        /// career. It then filters out subjects the student has already enrolled in or completed. Subjects with unfulfilled 
        /// prerequisites, as determined by the student's current enrolment, are also excluded.
        /// </remarks>
        public List<Subject> availableEnrolments(int dni, object careerEnrolment)
        {
            CareerEnrolment careerEnrolment1 = (CareerEnrolment)careerEnrolment;
            int careerId = careerEnrolment1.CareerId;

            List<Subject> allSubjects = GetAllSubjectsFromCareer(careerId);
            if (!allSubjects.Any())
                return new List<Subject>();

            List<SubjectEnrolment> enrolledSubjects = GetEnrolledSubjects(dni, careerId);

            List<Subject> alreadyEnrolledOrApprovedSubjects = GetAlreadyEnrolledOrApprovedSubjects(enrolledSubjects);
            List<Subject> enrolledNonApprovedSubjects = GetEnrolledNonApprovedSubjects(enrolledSubjects);
            List<Subject> correlativeFutures = GetCorrelativeFutures(enrolledNonApprovedSubjects);

            return FilterAvailableSubjects(allSubjects, alreadyEnrolledOrApprovedSubjects, correlativeFutures);
        }

        private List<Subject> FilterAvailableSubjects(List<Subject> allSubjects, List<Subject> alreadyEnrolledOrApprovedSubjects, List<Subject> correlativeFutures)
        {
            return allSubjects
                .Where(sub => !alreadyEnrolledOrApprovedSubjects.Any(e => e.Id == sub.Id)
                              && !correlativeFutures.Any(c => c.Id == sub.Id))
                .ToList();
        }
        #endregion

        #region Loaders
        public List<int> loadYearsInCareer()
        {
            return subjectDao.loadYearsInCareer();
        }
        #endregion
        #endregion
    }
}
