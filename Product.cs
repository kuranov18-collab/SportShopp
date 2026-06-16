using SportShop.Models;

namespace SportShop.Data;

public static class SeedData
{
    public static void Initialize(AppDbContext context)
    {
        // Проверяем, есть ли уже товары
        if (context.Products.Any()) return;

        var products = new Product[]
        {
            new Product { Name = "Баскетбольный мяч", Description = "Официальный мяч для матчей", Price = 2490m, ImageUrl = "/images/ball.jpg", Category = "Мячи", StockQuantity = 50 },
            new Product { Name = "Беговые кроссовки", Description = "Лёгкие и амортизирующие", Price = 5990m, ImageUrl = "/images/shoes.jpg", Category = "Обувь", StockQuantity = 30 },
            new Product { Name = "Фитнес-коврик", Description = "Противоскользящий", Price = 1290m, ImageUrl = "/images/mat.jpg", Category = "Фитнес", StockQuantity = 100 },
            new Product { Name = "Гантели 15 кг", Description = "Набор из двух гантелей", Price = 3490m, ImageUrl = "/images/dumbbells.jpg", Category = "Снаряды", StockQuantity = 20 },
            new Product { Name = "Футбольная форма", Description = "Комфорт и вентиляция", Price = 3990m, ImageUrl = "/images/jersey.jpg", Category = "Одежда", StockQuantity = 15 },
            new Product { Name = "Спортивный велосипед", Description = "Шоссейный велосипед", Price = 15990m, ImageUrl = "/images/bike.jpg", Category = "Велоспорт", StockQuantity = 10},
            new Product { Name = "Футбольные перчатки", Description = "Перчатки вратарские", Price = 3190m, ImageUrl = "/images/gloves.jpg", Category = "Одежда", StockQuantity = 25},
            new Product { Name = "Спортивный Рюкзак", Description = "Рюкзак велосипедный", Price = 2990m, ImageUrl = "/images/bag.jpg", Category = "Одежда", StockQuantity = 20}
        };
        context.Products.AddRange(products);
        context.SaveChanges();
    }
}