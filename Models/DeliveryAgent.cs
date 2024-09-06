using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodCart.Models
{
    public class DeliveryAgent
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        public int LocationId { get; set; }

        [Required]
        [Range(-90.0, 90.0, ErrorMessage = "Latitude must be between -90 and 90.")]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal Latitude { get; set; }

        [Required]
        [Range(-180.0, 180.0, ErrorMessage = "Longitude must be between -180 and 180.")]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal Longitude { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }

        public string RatingsAndReviews { get; set; }

        [Required]
        [StringLength(50)]
        public string AvailStatus { get; set; }


        public Users? Users { get; set; }

        public ICollection<Orders> Orders { get; set; } = new List<Orders>();

    }
}
