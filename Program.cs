using lr3.Services;

var builder = WebApplication.CreateBuilder(args);

// Додаємо сервіси для кожного з контролерів
builder.Services.AddTransient<CalcService>();
builder.Services.AddTransient<TimeService>();


builder.Services.AddControllersWithViews(); 

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.UseStaticFiles();

app.Run();
