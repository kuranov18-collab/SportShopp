using Microsoft.AspNetCore.Mvc;
using SportShop.Services;

namespace SportShop.Controllers;

public abstract class BaseController : Controller
{
    protected CartService CartService { get; }

    protected BaseController(CartService cartService)
    {
        CartService = cartService;
    }

    public override void OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context)
    {
        ViewBag.CartCount = CartService.GetCartCount();
        base.OnActionExecuting(context);
    }
}