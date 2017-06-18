using System.ComponentModel.DataAnnotations;

namespace log_reg.Models
{
    public class User : BaseEntity
    {
        [Required]
        [MinLength(2)]
        public string FirstName {get; set;}

        [Required]
        [MinLength(2)]
        public string LastName {get; set;}

        [Required]
        [EmailAddress]
        public string Email {get; set;}

        [Required]
        [MinLength(8)]
        public string Password {get; set;}

        [Required]
        [Compare("Password", ErrorMessage="Your passwords do not match!")]
        public string ConfirmPassword {get; set;}
    }
}