using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodCart.Models
{
    public class MenuItems
    {
        [Required]
        [Key]
        public int ItemID { get; set; }
        [Required]
        [StringLength(100)]
        public string ItemName { get; set; }

        [Required]
        public string ItemDescription { get; set; }
        [Required]
        [Range(0.01, 10000.00, ErrorMessage = "Price must be a positive value")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ItemPrice { get; set; }

        [Required]
        public string Ingredients { get; set; }
        [Required]
        public string CuisineType { get; set; }
        [Required]
        public string TasteInfo { get; set; }
        [Required]
        [StringLength(50)]
        public string AvailabilityStatus { get; set; }

        [Required]
        public string DietaryInfo { get; set; }
        public string ImageURL { get; set; }

        public int CategoryID { get; set; }

        public MenuCategory? MenuCategory { get; set; }




        public ICollection<OrderItems> OrderItems { get; set; } = new List<OrderItems>();
        public ICollection<Cart> Carts { get; set; } = new List<Cart>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();

        public ICollection<Restaurant> Restaurants { get; set; } = new List<Restaurant>();

    }
}
