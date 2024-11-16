using Landly.LandlyDbContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllHeaders",
        policyBuilder =>
        {
            policyBuilder.AllowAnyOrigin()
                         .AllowAnyHeader()
                         .AllowAnyMethod();
        });
});

builder.Services.AddDbContext<Landly_Db_Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCors("AllowAllHeaders");

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Configure ports from appsettings.json
var config = builder.Configuration;

int httpPort = config.GetValue<int>("HttpPort", 0);  // Default to 0 if not configured
int httpsPort = config.GetValue<int>("HttpsPort", 0); // Default to 0 if not configured

if (httpPort > 0 && httpsPort > 0)
{
    builder.WebHost.UseUrls($"http://*:{httpPort}", $"https://*:{httpsPort}");
}

app.Run();
