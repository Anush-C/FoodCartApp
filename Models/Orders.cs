using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodCart.Models
{
    public class Orders
    {
        [Required]
        [Key]
        public int OrderID { get; set; }
        [Required]
        [Range(0.01, 10000.00, ErrorMessage = "Price must be a positive value")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalPrice { get; set; }
        [Required]
        [StringLength(255)]
        public string ShippingAddress { get; set; }
        [Required]
        [StringLength(50)]
        [RegularExpression(@"^(Pending|Completed|Cancelled)$", ErrorMessage = "Invalid order status")]
        public string OrderStatus { get; set; }
        [Required]
        public DateTime OrderTime { get; set; }
        public DateTime? DeliveryTime { get; set; }

        public int UserID { get; set; }
        public int RestaurantID { get; set; }

        public int? DeliveryAgentID { get; set; }



        //Reference Navigation Property
        public Users? User { get; set; }
        public Restaurant? Restaurant { get; set; }
        public DeliveryAgent? DeliveryAgent { get; set; }

        //Collection Navigation Property
        public ICollection<OrderItems> OrderItems { get; set; } = new List<OrderItems>();



    }
}
