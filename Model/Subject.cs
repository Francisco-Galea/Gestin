using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestin.Model
{
    [Table("Subject")]
    public partial class Subject
    {
        public Subject()
        {
            CorrelativeCorrelativeSubjects = new HashSet<Correlative>();
            CorrelativeSubjects = new HashSet<Correlative>();
            Grades = new HashSet<Grade>();
            Schedules = new HashSet<Schedule>();
            SubjectEnrolments = new HashSet<SubjectEnrolment>();
            TeacherSubjects = new HashSet<TeacherSubject>();
        }

        [Key]
        public int Id { get; set; }
        public int CareerId { get; set; }
        [StringLength(200)]
        public string Name { get; set; } = null!;
        public int YearInCareer { get; set; }
        public int AnnualHourlyLoad { get; set; }
        public string? Cupof { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [StringLength(50)]
        public string LastModificationBy { get; set; } = null!;


        [ForeignKey("CareerId")]
        [InverseProperty("Subjects")]
        public virtual Career Career { get; set; } = null!;
        [InverseProperty("CorrelativeSubject")]
        public virtual ICollection<Correlative> CorrelativeCorrelativeSubjects { get; set; }
        [InverseProperty("Subject")]
        public virtual ICollection<Correlative> CorrelativeSubjects { get; set; }
        [InverseProperty("IdSubjectNavigation")]
        public virtual ICollection<Exam> Exams { get; set; }
        [InverseProperty("Subject")]
        public virtual ICollection<Grade> Grades { get; set; }
        [InverseProperty("Subject")]
        public virtual ICollection<Schedule> Schedules { get; set; }
        [InverseProperty("Subject")]
        public virtual ICollection<SubjectEnrolment> SubjectEnrolments { get; set; }
        [InverseProperty("Subject")]
        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }

        public Subject(int id)
        {
            Id = id;
        }

        public Subject(int careerId, string name, int yearInCareer, int annualHourlyLoad) //CREATE
        {
            CareerId = careerId;
            Name = name;
            YearInCareer = yearInCareer;
            AnnualHourlyLoad = annualHourlyLoad;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
