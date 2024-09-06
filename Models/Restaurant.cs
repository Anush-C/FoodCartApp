﻿using System.ComponentModel.DataAnnotations;

namespace FoodCart.Models
{
    public class Restaurant
    {
        [Required]
        [Key]
        public int RestaurantID { get; set; }

        [Required]
        [StringLength(100)]
        public string RestaurantName { get; set; }

        public string RestaurantDescription { get; set; }

        [Required]
        [Phone]
        public string RestaurantPhone { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string RestaurantEmail { get; set; }

        [Required, StringLength(255)]
        public string RestaurantAddress { get; set; }

        [Required]
        public TimeSpan OpeningHours { get; set; }

        [Required]
        public TimeSpan ClosingHours { get; set; }


        //Navigation Property
        public ICollection<Orders> Orders { get; set; } = new List<Orders>();
        public ICollection<MenuItems> MenuItems { get; set; } = new List<MenuItems>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();


    }
}
