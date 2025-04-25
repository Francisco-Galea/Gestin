using Gestin.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestin.Model
{
    [Table("Student")]
    public partial class Student : IUserType
    {
        public Student()
        {
            CareerEnrolments = new HashSet<CareerEnrolment>();
            Grades = new HashSet<Grade>();
            SubjectEnrolments = new HashSet<SubjectEnrolment>();
        }

        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LoginInformationId { get; set; }
        public bool DniPhotocopy { get; set; }
        public bool HighSchoolTitPhotocopy { get; set; }
        public bool Photo4x4 { get; set; }
        public bool MedicalCertificate { get; set; }
        public bool BirthCertificate { get; set; }
        public bool CuilConstansy { get; set; }
        public bool Cooperative { get; set; }
        [StringLength(50)]
        public string? SocialWork { get; set; }
        [StringLength(50)]
        public string? WorkActivity { get; set; }
        [StringLength(50)]
        public string? WorkingHours { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [StringLength(50)]
        public string LastModificationBy { get; set; } = null!;

        [ForeignKey("LoginInformationId")]
        [InverseProperty("Students")]
        public virtual LoginInformation LoginInformation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("Students")]
        public virtual User User { get; set; } = null!;
        [InverseProperty("Student")]
        public virtual ICollection<CareerEnrolment> CareerEnrolments { get; set; }
        [InverseProperty("Student")]
        public virtual ICollection<Grade> Grades { get; set; }
        [InverseProperty("Student")]
        public virtual ICollection<SubjectEnrolment> SubjectEnrolments { get; set; }

        public override string ToString()
        {
            return $"{User.LastName} {User.Name} {User.Dni}";
        }

        public string getUserFullName()
        {
            return $"{User.LastName}, {User.Name}";
        }

        public string getUserRoleType()
        {
            return "Estudiante";
        }

        public string getUserEmail()
        {
            return LoginInformation.Email;
        }

        public string getUserRoleAndName()
        {
            return $"{"Estudiante:"} {User.LastName} {User.Name}";
        }
    }
}
