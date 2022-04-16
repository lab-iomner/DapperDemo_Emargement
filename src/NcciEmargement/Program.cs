using NcciEmargement.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<NcciEmargDbContext>(options =>
    options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();



//public void ConfigureServices(IServiceCollection services)
//{
//    services.AddControllers();

//    services.AddDbContext<ApplicationDbContext>(
//        options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
//}

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
