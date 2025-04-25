using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestin.Model
{
    [Table("Exam")]
    [Index("Id", Name = "IX_EXAMENES", IsUnique = true)]
    public partial class Exam
    {
        [Key]
        public int Id { get; set; }
        public int IdSubject { get; set; }
        public int? FirstVowel { get; set; }
        public int? SecondVowel { get; set; }
        public int? ThirdVowel { get; set; }
        public int? Titular { get; set; }
        public string? Place { get; set; }
        public string Period { get; set; } = null!;
        public string? Call { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [StringLength(50)]
        public string LastModificationBy { get; set; } = null!;

        [ForeignKey("FirstVowel")]
        [InverseProperty("ExamFirstVowelNavigations")]
        public virtual Teacher? FirstVowelNavigation { get; set; }
        [ForeignKey("IdSubject")]
        [InverseProperty("Exams")]
        public virtual Subject IdSubjectNavigation { get; set; } = null!;
        [ForeignKey("SecondVowel")]
        [InverseProperty("ExamSecondVowelNavigations")]
        public virtual Teacher? SecondVowelNavigation { get; set; }
        [ForeignKey("ThirdVowel")]
        [InverseProperty("ExamThirdVowelNavigations")]
        public virtual Teacher? ThirdVowelNavigation { get; set; }
        [ForeignKey("Titular")]
        [InverseProperty("ExamTitularNavigations")]
        public virtual Teacher? TitularNavigation { get; set; }

        public int SubjectEnrolmentCareerId()
        {
            return IdSubjectNavigation.CareerId;
        }

        public string SubjectEnrolmentName()
        {
            return IdSubjectNavigation.Name;
        }

        List<string> callDomain = new()
        {
            "Primer", "Segundo", "Tercer"
        };

        public void assignExamCallNumberInDomain(int index)
        {
            if (index < callDomain.Count)
            {
                Call = callDomain[index];
            }
            else
            {
                Call = Convert.ToString(++index);
            }
        }

        

    }
}
