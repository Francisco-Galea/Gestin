using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestin.Model
{
    [Table("Schedule")]
    public partial class Schedule
    {
        [Key]
        public int Id { get; set; }
        public int SubjectId { get; set; }
        [StringLength(50)]
        public string Day { get; set; } = null!;
        public TimeSpan StartingTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [StringLength(50)]
        public string LastModificationBy { get; set; } = null!;

        [ForeignKey("SubjectId")]
        [InverseProperty("Schedules")]
        public virtual Subject Subject { get; set; } = null!;
    }
}
