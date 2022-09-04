
using System.ComponentModel.DataAnnotations;
namespace FormPractice.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
