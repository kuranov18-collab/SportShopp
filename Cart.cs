using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportShop.Data;
using SportShop.Models;
using SportShop.Services;  

namespace SportShop.Controllers;

public class HomeController : BaseController 
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context, CartService cartService)
        : base(cartService)  // передаём cartService в базовый контроллер
    {
        _context = context;
    }

    // Главная страница со списком товаров
    public async Task<IActionResult> Index()
    {
        var products = await _context.Products.ToListAsync();
        return View(products);
    }

    // Детальная страница товара
    public async Task<IActionResult> Details(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null) return NotFound();
        return View(product);
    }

    // Страница "О нас"
    public IActionResult About()
    {
        return View();
    }
}