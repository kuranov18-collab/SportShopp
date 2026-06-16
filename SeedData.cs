using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportShop.Data;
using SportShop.Services;

namespace SportShop.Controllers;

public class CartController : BaseController
{
    private readonly AppDbContext _context;

    public CartController(CartService cartService, AppDbContext context)
        : base(cartService)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var cart = this.CartService.GetCart();      // явное указание this
        return View(cart);
    }

    [HttpPost]
    public async Task<IActionResult> AddToCart(int id, int quantity = 1)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null) return NotFound();

        this.CartService.AddToCart(product, quantity);
        return Redirect(Request.Headers["Referer"].ToString());
    }

    [HttpPost]
    public IActionResult RemoveFromCart(int productId)
    {
        this.CartService.RemoveFromCart(productId);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult UpdateQuantity(int productId, int quantity)
    {
        this.CartService.UpdateQuantity(productId, quantity);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult ClearCart()
    {
        this.CartService.ClearCart();
        return RedirectToAction(nameof(Index));
    }
}