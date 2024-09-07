using FoodCart.Models;

namespace FoodCart.Repositories
{
    public interface ICartRepository
    {
        Task<Cart> AddToCart(Cart cart);
        Task<Cart> UpdateCart(int cartId,Cart cart);
        Task<Cart> DeleteCart(int cartId);

        Task<IEnumerable<Cart>> ViewCart(int userid  );

        Task<BillingDetailsDto> TotalCost(int userid);
        Task<Orders> Checkout(int userId, string shippingAddress, string paymentMethod, int restaurantId, int? deliveryagentId = null, string bankName = null, string accountNumber = null, string cardNumber = null, string cardHolderName = null, string upiId = null);
    }
}
