using System.ComponentModel.DataAnnotations;
namespace woods{
    public class Trail{
        [Required]
        string TrailName{get; set;}

        [Required]
        [MinLength(10)]
        string Description{get; set;}

        [Required]
        int TrailLength{get; set;}

        [Required]
        int ElevationChange{get; set;}

        [Required]
        int Long{get;set;}

        [Required]
        int Lat{get;set;}
    }
}