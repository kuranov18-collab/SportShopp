using Microsoft.EntityFrameworkCore;
using SportShop.Data;
using SportShop.Services;

var builder = WebApplication.CreateBuilder(args);

// Добавляем MVC и API контроллеры
builder.Services.AddControllersWithViews();
// Добавляем сессии (необходимы для хранения корзины)
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromDays(7); // корзина живёт 7 дней
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// Регистрируем сервис корзины
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<CartService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Регистрируем контекст БД (SQLite)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Настройка конвейера обработки запросов
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();
app.UseRouting();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Инициализация БД (создание и заполнение тестовыми данными)
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.EnsureCreated(); // создаст БД и таблицы, если их нет
    SeedData.Initialize(dbContext);     // заполним тестовыми товарами
}

app.Run();