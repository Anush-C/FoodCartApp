using Microsoft.AspNetCore.Mvc;
using FoodCart.Repositories;
using FoodCart.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace FoodCart.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartRepository _cartRepository;

        public CartController(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        // Add an item to the cart
        [HttpPost("add")]
        public async Task<IActionResult> AddToCart([FromBody] Cart cart)
        {
            var result = await _cartRepository.AddToCart(cart);
            return CreatedAtAction(nameof(ViewCart), new { userId = cart.UserID }, result);
        }

        // Update an item in the cart
        [HttpPut("update/{cartId}")]
        public async Task<IActionResult> UpdateCart(int cartId, [FromBody] Cart cart)
        {
            var updatedCart = await _cartRepository.UpdateCart(cartId, cart);
            if (updatedCart == null)
                return NotFound();

            return Ok(updatedCart);
        }

        // Delete an item from the cart
        [HttpDelete("delete/{cartId}")]
        public async Task<IActionResult> DeleteCart(int cartId)
        {
            var deletedCart = await _cartRepository.DeleteCart(cartId);
            if (deletedCart == null)
                return NotFound();

            return Ok(deletedCart);
        }

        // View all items in the user's cart
        [HttpGet("view/{userId}")]
        public async Task<IActionResult> ViewCart(int userId)
        {
            var carts = await _cartRepository.ViewCart(userId);
            return Ok(carts);
        }

        // Get total cost of items in the user's cart
        [HttpGet("totalcost/{userId}")]
        public async Task<IActionResult> GetTotalCost(int userId)
        {
            var billingDetails = await _cartRepository.TotalCost(userId);
            return Ok(billingDetails);
        }

        // Checkout the cart
        [HttpPost("checkout")]
        public async Task<IActionResult> Checkout(
            [FromQuery] int userId,
            [FromQuery] string shippingAddress,
            [FromQuery] string paymentMethod,
            [FromQuery] int restaurantId,
            [FromQuery] int? deliveryAgentId = null,
            [FromQuery] string bankName = null,
            [FromQuery] string accountNumber = null,
            [FromQuery] string cardNumber = null,
            [FromQuery] string cardHolderName = null,
            [FromQuery] string upiId = null)
        {
            var order = await _cartRepository.Checkout(userId, shippingAddress, paymentMethod, restaurantId, deliveryAgentId, bankName, accountNumber, cardNumber, cardHolderName, upiId);
            return Ok(order);
        }
    }
}
