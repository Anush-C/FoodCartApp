using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FoodCart.Models
{
    public class Cart
    {
        [Required]
        [Key]
        public int CartID { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }

        [Required]
        [StringLength(255)]
        public string DeliveryAddress { get; set; }

        [Required]
        [Range(0.01, 10000.00, ErrorMessage = "Total Cost must be a positive value.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalCost { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        public int ItemID { get; set; }
        public int UserID { get; set; }

       
        public MenuItems? MenuItems { get; set; }

        [JsonIgnore] // Exclude from JSON serialization
        public Users? Users { get; set; }
    }
}
