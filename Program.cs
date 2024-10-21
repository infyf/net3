var builder = WebApplication.CreateBuilder(args);

// Додаємо контролери з поданнями
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Налаштування маршрутизації
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Product}/{action=Index}/{id?}");
});

app.Run();
