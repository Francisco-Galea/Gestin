using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestin.Model
{
    [Table("SessionToken")]
    public partial class SessionToken
    {
        [Key]
        public int Id { get; set; }
        public string sessionToken { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public int LoginInformationId { get; set; }

        [ForeignKey("LoginInformationId")]
        [InverseProperty("SessionTokens")]
        public virtual LoginInformation LoginInformation { get; set; } = null!;
    }
}
