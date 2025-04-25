using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestin.Model
{
    [Table("User")]
    [Index("Dni", Name = "IX_User", IsUnique = true)]
    public partial class User
    {
        public User()
        {
            Students = new HashSet<Student>();
            Teachers = new HashSet<Teacher>();
        }

        [Key]
        public int Id { get; set; }
        public int Dni { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [StringLength(50)]
        public string LastName { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; } = null;
        [StringLength(500)]
        public string? PlaceOfBirth { get; set; }
        [StringLength(50)]
        public string? PhoneNumbre { get; set; }
        [StringLength(50)]
        public string? EmergencyPhoneNumber { get; set; }
        [StringLength(50)]
        public string? Gender { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [StringLength(50)]
        public string LastModificationBy { get; set; } = null!;

        [InverseProperty("User")]
        public virtual ICollection<Student> Students { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Teacher> Teachers { get; set; }

        public override string ToString()
        {
            return $"{LastName}, {Name}";
        }
        public string fullName()
        {
            return $"{LastName}, {Name}";
        }
    }
}
