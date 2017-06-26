using System.ComponentModel.DataAnnotations;

namespace Productivity_Cards.Models
{
    public class User : BaseEntity
    {
        public int user_id {get;set;}
        
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string first_name { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string last_name { get; set; }

        [Required]
        [MinLength(2)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string alias { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        [MinLength(8)]
        public string password { get; set; }

        [Compare("password", ErrorMessage="Your passwords don't match!")]
        public string confirm_password { get; set; }
        public string created_at {get;set;}
        public string updated_at {get;set;}
    }
}