using System.ComponentModel.DataAnnotations;
namespace MODELSTATE.Models
{
    public class Customer
    {
        [Required]
        [StringLength(5)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}