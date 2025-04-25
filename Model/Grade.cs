using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestin.Model
{
    [Table("Grade")]
    public partial class Grade
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        [Column("Grade")]
        public int Grade1 { get; set; }
        [StringLength(50)]
        public string? BookRecord { get; set; }
        public DateTime? AccreditationDate { get; set; }
        [StringLength(50)]
        public string AccreditationType { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [StringLength(50)]
        public string LastModificationBy { get; set; } = null!;

        [ForeignKey("StudentId")]
        [InverseProperty("Grades")]
        public virtual Student Student { get; set; } = null!;
        [ForeignKey("SubjectId")]
        [InverseProperty("Grades")]
        public virtual Subject Subject { get; set; } = null!;

        public override string? ToString()
        {
            return Grade1 > 0 ? Grade1.ToString() : string.Empty;
        }
    }
}
