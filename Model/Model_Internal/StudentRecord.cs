namespace Gestin.Model.Model_Internal
{
    public class StudentRecord //Model for formAcademicRecord
    {
        Grade grade { get; set; }
        SubjectEnrolment subjectEnrolment { get; set; }

        public StudentRecord()
        {
        }

        public StudentRecord(Grade grade, SubjectEnrolment subjectEnrolment)
        {
            this.grade = grade;
            this.subjectEnrolment = subjectEnrolment;
        }

        public Grade Grade { get => grade; set => grade = value; }
        public SubjectEnrolment SubjectEnrolment { get => subjectEnrolment; set => subjectEnrolment = value; }
        public Subject Subject { get => subjectEnrolment.Subject; }
        public int? GradeId { get => grade.Id; }
        public string? GradeAccreditationType { get => grade.AccreditationType; }
        public DateTime? GradeAccreditationDate { get => grade.AccreditationDate; }
        public string? GradeBookRecord { get => grade.BookRecord; }
        public int? SubjectEnrolmentId { get => subjectEnrolment.Id; }
        public int? SubjectYearInCareer { get => subjectEnrolment.Subject.YearInCareer; }
        public int? SubjectEnrolmentYear { get => subjectEnrolment.Year; }
        public bool SubjectEnrolmentPresential { get => subjectEnrolment.Presential; }
        public bool SubjectEnrolmentApproved { get => subjectEnrolment.Approved; }

        public override string? ToString()
        {
            if (Grade != null && SubjectEnrolment != null)
            {
                return $"{GradeId} {SubjectYearInCareer} {Subject} {SubjectEnrolmentYear} {GradeAccreditationDate} {SubjectEnrolmentPresential} {SubjectEnrolmentApproved} {Grade} {GradeBookRecord} {SubjectEnrolmentId}";
            }
            return base.ToString();
        }

        /*
        int? gradeId;
        int? subjectYearInCareer;
        Subject? subject;
        int? subjectEnrolmentYear;
        string? gradeAccreditationDate;
        bool subjectEnrolmentPresential;
        bool subjectEnrolmentApproved;
        string? gradeAccreditationType;
        Grade? grade;
        string? gradeBookRecord;
        int? subjectEnrolmentId;
        string? studentName;

        public StudentRecord()
        {
        }

        public int? GradeId { get => gradeId; set => gradeId = value; }
        public int? SubjectYearInCareer { get => subjectYearInCareer; set => subjectYearInCareer = value; }
        public Subject? Subject { get => subject; set => subject = value; }
        public int? SubjectEnrolmentYear { get => subjectEnrolmentYear; set => subjectEnrolmentYear = value; }
        public string? GradeAccreditationDate { get => gradeAccreditationDate; set => gradeAccreditationDate = value; }
        public bool SubjectEnrolmentPresential { get => subjectEnrolmentPresential; set => subjectEnrolmentPresential = value; }
        public bool SubjectEnrolmentApproved { get => subjectEnrolmentApproved; set => subjectEnrolmentApproved = value; }
        public string? GradeAccreditationType { get => gradeAccreditationType; set => gradeAccreditationType = value; }
        public Grade? Grade { get => grade; set => grade = value; }
        public string? GradeBookRecord { get => gradeBookRecord; set => gradeBookRecord = value; }
        public int? SubjectEnrolmentId { get => subjectEnrolmentId; set => subjectEnrolmentId = value; }
        public string? StudentName { get => studentName; set => studentName = value; }

        */
    }
}
