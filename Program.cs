using lr3.Services;

var builder = WebApplication.CreateBuilder(args);

// Додаємо сервіси для кожного з контролерів
builder.Services.AddTransient<CalcService>();
builder.Services.AddTransient<TimeService>();

// Додаємо контролери
builder.Services.AddControllers();

var app = builder.Build();

// Налаштовуємо маршрутизацію для контролерів
app.MapControllers();

app.Run();