using System.ComponentModel.DataAnnotations;
namespace ECommerce.Models{
    public class Customer : BaseEntity {
        [Key]
        public long Id {get; set;}

        [Required]
        public string customer_name {get; set;}

    }
}
