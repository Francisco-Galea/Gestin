using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestin.Model
{
    [Keyless]
    [Table("ExamEnrolmentConfig")]
    public partial class ExamEnrolmentConfig
    {
        public int Id { get; set; }
        public DateTime? ExamEnrolmentStartDate { get; set; }
        public DateTime? ExamEnrolmentCloseDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [StringLength(50)]
        public string LastModificationBy { get; set; } = null!;
    }
}
