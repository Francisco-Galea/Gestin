using DocumentFormat.OpenXml.Wordprocessing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestin.Model
{
    [Table("CareerEnrolment")]
    public partial class CareerEnrolment
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CareerId { get; set; }
        public int YearOfRegistration { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [StringLength(50)]
        public string LastModificationBy { get; set; } = null!;

        [ForeignKey("CareerId")]
        [InverseProperty("CareerEnrolments")]
        public virtual Career Career { get; set; } = null!;
        [ForeignKey("StudentId")]
        [InverseProperty("CareerEnrolments")]
        public virtual Student Student { get; set; } = null!;

        public override string ToString()
        {
            return $"{Career.Name}";
        }
    }
}
