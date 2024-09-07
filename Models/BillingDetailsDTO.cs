namespace FoodCart.Models
{
    using System.ComponentModel.DataAnnotations;

    public class BillingDetailsDto
    {
        [Required]
        [Range(0.00, double.MaxValue, ErrorMessage = "Item Total must be a non-negative value.")]
        [Display(Name = "Item Total")]
        [DataType(DataType.Currency)]
        public decimal ItemTotal { get; set; }

        [Required]
        [Range(0.00, double.MaxValue, ErrorMessage = "Delivery Partner Fee must be a non-negative value.")]
        [Display(Name = "Delivery Partner Fee")]
        [DataType(DataType.Currency)]
        public decimal DeliveryPartnerFee { get; set; }

        [Range(0.00, double.MaxValue, ErrorMessage = "Delivery Tip must be a non-negative value.")]
        [Display(Name = "Delivery Tip")]
        [DataType(DataType.Currency)]
        public decimal DeliveryTip { get; set; }

        [Required]
        [Range(0.00, double.MaxValue, ErrorMessage = "Platform Fee must be a non-negative value.")]
        [Display(Name = "Platform Fee")]
        [DataType(DataType.Currency)]
        public decimal PlatformFee { get; set; }

        [Required]
        [Range(0.00, double.MaxValue, ErrorMessage = "GST and Charges must be a non-negative value.")]
        [Display(Name = "GST and Charges")]
        [DataType(DataType.Currency)]
        public decimal GstAndCharges { get; set; }

        [Required]
        [Range(0.00, double.MaxValue, ErrorMessage = "Total Payable must be a non-negative value.")]
        [Display(Name = "Total Payable")]
        [DataType(DataType.Currency)]
        public decimal TotalPayable { get; set; }
    }

}
