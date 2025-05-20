using ElectronicProductsAPI.Data;
using ElectronicProductsAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ربط قاعدة البيانات (غير الاتصال حسب إعداداتك في appsettings.json)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// تسجيل الخدمات الخاصة بك
builder.Services.AddScoped<ChatBotService>();
builder.Services.AddScoped<ExternalAIService>();

// إضافة دعم Controllers
builder.Services.AddControllers();

var app = builder.Build();

// إذا عندك ملفات static
app.UseStaticFiles();

// تفعيل التوجيه
app.MapControllers();

app.Run();