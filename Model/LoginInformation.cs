using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestin.Model
{
    [Table("LoginInformation")]
    public partial class LoginInformation
    {
        public LoginInformation()
        {
            Students = new HashSet<Student>();
            Teachers = new HashSet<Teacher>();
            SessionTokens = new HashSet<SessionToken>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Email { get; set; } = null!;
        [StringLength(500)]
        public string Password { get; set; } = null!;
        public byte[]? Salt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [StringLength(50)]

        public string LastModificationBy { get; set; } = null!;

        [InverseProperty("LoginInformation")]
        public virtual ICollection<Student> Students { get; set; }
        [InverseProperty("LoginInformation")]
        public virtual ICollection<Teacher> Teachers { get; set; }
        [InverseProperty("LoginInformation")]
        public virtual ICollection<SessionToken> SessionTokens { get; set; }
    }
}
