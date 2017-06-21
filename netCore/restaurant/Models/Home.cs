using System.ComponentModel.DataAnnotations;

namespace restaurant
{
    public class Review : BaseEntity{
        [Required]
        string reviewer_name{get;set;}

        [Required]
        string restaurant_name{get;set;}

        [Required]
        [MinLength(10)]
        string review{get;set;}

        [Required]
        string date{get;set;}

        [Required]
        int stars {get;set;}

        



    }    
}