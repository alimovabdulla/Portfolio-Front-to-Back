using Microsoft.EntityFrameworkCore;
using Portfolio.Areas.AdminPanel.Helper.MethodsService;
using Portfolio.DbContext;
using Portfolio.Helper.DbService;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ClassDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<PortfolioDbService>();
builder.Services.AddScoped<MethodsService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	"areas",
			"{area:exists}/{controller=Home}/{action=Edit}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
