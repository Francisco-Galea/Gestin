using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestin.Model
{
    [Table("SubjectEnrolment")]
    public partial class SubjectEnrolment
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Year { get; set; }
        public bool Approved { get; set; }
        public bool Presential { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [StringLength(50)]
        public string LastModificationBy { get; set; } = null!;

        [ForeignKey("StudentId")]
        [InverseProperty("SubjectEnrolments")]
        public virtual Student Student { get; set; } = null!;
        [ForeignKey("SubjectId")]
        [InverseProperty("SubjectEnrolments")]
        public virtual Subject Subject { get; set; } = null!;

        public string getSubjectName()
        {
            return Subject.Name;
        }

        public override string? ToString()
        {
            return getSubjectName();
        }
    }
}
