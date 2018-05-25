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

        public string Name { get; set; }

        [UIHint("Currency")]
        public int Price { get; set; }

        [Display(Name = "Amount in storage")]
        public int Quantity { get; set; }

        public Category Category { get; set; }

        public string Description { get; set; }
    }
}