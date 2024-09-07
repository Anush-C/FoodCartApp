using FoodCart.Data;
using FoodCart.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodCart.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDbContext _context;
        public CartRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;

        }

        public async Task<Cart> AddToCart(Cart cart)
        {
            await _context.Carts.AddAsync(cart);
            await _context.SaveChangesAsync();

            return cart;

        }

        public async Task<Cart?> UpdateCart(int cartid, Cart cart)
        {
            var carts = await _context.Carts.FindAsync(cartid);
            if (carts == null)
            {
                return null;
            }
            carts.Quantity = cart.Quantity;
            carts.TotalCost = cart.TotalCost;
            carts.UpdatedAt = DateTime.Now;
            await _context.SaveChangesAsync();
            return carts;

        }

        public async Task<Cart?> DeleteCart(int cartid)
        {
            var carts = await _context.Carts.FindAsync(cartid);
            if (carts == null)
            {
                return null;
            }
            _context.Carts.Remove(carts);
            await _context.SaveChangesAsync();
            return carts;

        }

        public async Task<IEnumerable<Cart>> ViewCart(int userid)
        {
            return await _context.Carts.Include(mi => mi.MenuItems).Where(mi => mi.UserID == userid).ToListAsync();

        }

        public async Task<BillingDetailsDto> TotalCost(int userid)
        {
            var menu = await _context.Carts.Where(mi => mi.UserID == userid).ToListAsync();

            decimal total = menu.Sum(mi => mi.TotalCost);
            decimal deliveryPartnerFee = 22m;
            decimal platformFee = 6m;
            decimal gstRate = 0.10m;
            decimal gstAndCharges = total * gstRate;
            decimal totalCost = total + deliveryPartnerFee + platformFee + gstAndCharges;
            return new BillingDetailsDto
            {
                ItemTotal = total,
                DeliveryPartnerFee = deliveryPartnerFee,
                PlatformFee = platformFee,
                GstAndCharges = gstAndCharges,
                TotalPayable = totalCost
            };
        }

        public async Task<Orders> Checkout(
     int userId,
     string shippingAddress,
     string paymentMethod,
     int restaurantId,
     int? deliveryAgentId = null,
     string bankName = null,
     string accountNumber = null,
     string cardNumber = null,
     string cardHolderName = null,
     string upiId = null)
        {

            var cartItems = await _context.Carts.Where(c => c.UserID == userId).ToListAsync();
            decimal totalAmount = cartItems.Sum(item => item.TotalCost);

           
            var order = new Orders
            {
                UserID = userId,
                ShippingAddress = shippingAddress,
                TotalPrice = totalAmount,
                OrderTime = DateTime.Now,
                RestaurantID = restaurantId,
                DeliveryAgentID = deliveryAgentId
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            var payment = new Payment
            {
                PaymentMethod = paymentMethod,
                PaymentStatus = "Pending",
                TransDateTime = DateTime.Now,
                OrderID = order.OrderID
            };

            switch (paymentMethod)
            {
                case "NetBanking":
                    if (string.IsNullOrEmpty(bankName) || string.IsNullOrEmpty(accountNumber))
                        throw new ArgumentException("BankName and AccountNumber are required for NetBanking.");

                    payment.NetBankingPayment = new NetBankingPayment
                    {
                        BankName = bankName,
                        AccountNumber = accountNumber
                    };
                    break;
                case "Card":
                    if (string.IsNullOrEmpty(cardNumber) || string.IsNullOrEmpty(cardHolderName))
                        throw new ArgumentException("CardNumber and CardHolderName are required for Card payment.");

                    payment.CardPayment = new CardPayment
                    {
                        CardNumber = cardNumber,
                        CardHolderName = cardHolderName
                    };
                    break;
                case "UPI":
                    if (string.IsNullOrEmpty(upiId))
                        throw new ArgumentException("UPI ID is required for UPI payment.");

                    payment.UpiPayment = new UpiPayment
                    {
                        UpiId = upiId
                    };
                    break;
                default:
                    throw new ArgumentException("Invalid payment method", nameof(paymentMethod));
            }

            _context.Payments.Add(payment);
            await _context.SaveChangesAsync();

            return order;
        }
    }

 }
