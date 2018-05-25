using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public enum Category {
        Electronics,
        Appliances,
        Toys
    }

    public class Product
    {
       
        public int Id { get; set; }
        
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [Range(1, int.MaxValue)]
        [UIHint("Currency")]
        public int Price { get; set; }

        [Range(0, int.MaxValue)]
        [Display(Name = "Amount in storage")]
        public int Quantity { get; set; }

        public Category Category { get; set; }

        public string Description { get; set; }
    }
}