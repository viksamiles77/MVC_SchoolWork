using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Class_05_DemoApp2.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Полето за име е задолжително!")]
        [StringLength(100)]
        [DisplayName("FirstName")]
        [RegularExpression("[a-zA-z]+", ErrorMessage = "Името мора да е составено само од букви!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Полето за презиме е задолжително!")]
        public string LastName { get; set; }
        [Required]
        [RegularExpression("F|M")]
        public char Gender { get; set; }
        [Required]
        public GroupEnum Group { get; set; }
    }
}