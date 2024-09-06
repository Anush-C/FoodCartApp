using System.ComponentModel.DataAnnotations;

namespace FoodCart.Models
{
    public class Notification
    {
        [Key]
        public int NotificationID { get; set; }

        public int UserID { get; set; }

        public int ItemID { get; set; }

        public int RestID { get; set; }

        [Required]
        [StringLength(50)]
        public string NotificationType { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public DateTime NotificationTime { get; set; }

        // Navigation properties
        public Users? Users { get; set; }
        public MenuItems? MenuItems { get; set; }
        public Restaurant? Restaurant { get; set; }
    }
}
