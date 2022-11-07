using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RamosGuillenTrujilloProyectoPorgreso1.Data;
using Microsoft.AspNetCore.Identity;
using RamosGuillenTrujilloProyectoPorgreso1.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RamosGuillenTrujilloProyectoPorgreso1Context5>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RamosGuillenTrujilloProyectoPorgreso1Context5Connection") ?? throw new InvalidOperationException("Connection string 'RamosGuillenTrujilloProyectoPorgreso1Context' not found.")));

builder.Services.AddDefaultIdentity<ApplicationUser5>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<RamosGuillenTrujilloProyectoPorgreso1Context5>();

// Add services to the container.
builder.Services.AddControllersWithViews();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
