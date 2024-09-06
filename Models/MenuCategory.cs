using System.ComponentModel.DataAnnotations;

namespace FoodCart.Models
{
    public class MenuCategory
    {
        [Required]
        [Key]
        public int CategoryID { get; set; }
        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public ICollection<MenuItems> MenuItems { get; set; } = new List<MenuItems>();

    }
}
