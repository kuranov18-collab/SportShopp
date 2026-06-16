using System.Text.Json;
using SportShop.Models;

namespace SportShop.Services;

public class CartService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ISession _session;

    public CartService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
        _session = _httpContextAccessor.HttpContext!.Session;
    }

    public Cart GetCart()
    {
        var cartJson = _session.GetString("Cart");
        if (string.IsNullOrEmpty(cartJson))
            return new Cart();

        return JsonSerializer.Deserialize<Cart>(cartJson) ?? new Cart();
    }

    public void SaveCart(Cart cart)
    {
        var cartJson = JsonSerializer.Serialize(cart);
        _session.SetString("Cart", cartJson);
    }

    public void AddToCart(Product product, int quantity = 1)
    {
        var cart = GetCart();
        var existingItem = cart.Items.FirstOrDefault(i => i.ProductId == product.Id);

        if (existingItem != null)
            existingItem.Quantity += quantity;
        else
        {
            cart.Items.Add(new CartItem
            {
                ProductId = product.Id,
                ProductName = product.Name,
                Price = product.Price,
                Quantity = quantity,
                ImageUrl = product.ImageUrl
            });
        }
        SaveCart(cart);
    }

    public void RemoveFromCart(int productId)
    {
        var cart = GetCart();
        var item = cart.Items.FirstOrDefault(i => i.ProductId == productId);
        if (item != null)
        {
            cart.Items.Remove(item);
            SaveCart(cart);
        }
    }

    public void UpdateQuantity(int productId, int newQuantity)
    {
        if (newQuantity <= 0)
        {
            RemoveFromCart(productId);
            return;
        }
        var cart = GetCart();
        var item = cart.Items.FirstOrDefault(i => i.ProductId == productId);
        if (item != null)
        {
            item.Quantity = newQuantity;
            SaveCart(cart);
        }
    }

    public void ClearCart()
    {
        _session.Remove("Cart");
    }

    public int GetCartCount()
    {
        return GetCart().Items.Sum(i => i.Quantity);
    }
}