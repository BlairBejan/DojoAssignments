using System.ComponentModel.DataAnnotations;

namespace the_wall.Models
{
    public class User : BaseEntity
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$")]
        [MinLength(2)]
        public string first_name {get; set;}

        [Required]
        [RegularExpression(@"^[a-zA-Z]+$")]
        [MinLength(2)]
        public string last_name {get; set;}

        [Required]
        [EmailAddress]
        public string email {get; set;}

        [Required]
        [MinLength(8)]
        public string password {get; set;}

        [Required]
        [Compare("password", ErrorMessage="Your passwords do not match!")]
        public string confirm_password {get; set;}
    }
}