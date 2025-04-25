using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestin.Model
{
    [Table("Correlative")]
    public partial class Correlative
    {
        [Key]
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int CorrelativeSubjectId { get; set; }
        public bool CorrelativeFinal { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [StringLength(50)]
        public string LastModificationBy { get; set; } = null!;

        [ForeignKey("CorrelativeSubjectId")]
        [InverseProperty("CorrelativeCorrelativeSubjects")]
        public virtual Subject CorrelativeSubject { get; set; } = null!;
        [ForeignKey("SubjectId")]
        [InverseProperty("CorrelativeSubjects")]
        public virtual Subject Subject { get; set; } = null!;

        public override string ToString()
        {
            return CorrelativeSubject.Name;
        }

    }
}
