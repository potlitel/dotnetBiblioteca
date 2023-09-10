using BootstrapDashboard.Middleware;
using BootstrapDashboard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
// using AspNetCoreHero.ToastNotification;
// using NToastNotify;

var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.
// builder.Services.AddRazorPages().AddNToastNotifyNoty(new NotyOptions
// {
//     ProgressBar = true,
//     Timeout = 5000
// });

// // Add ToastNotification
// builder.Services.AddNotyf(config =>
// {
//     config.DurationInSeconds = 5;
//     config.IsDismissable = true;
//     config.Position = NotyfPosition.TopRight;
// });

builder.Services.AddDbContext<BibliotecaContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Add services to the container.
builder.Services.AddControllersWithViews();

IoC.AddDependency(builder.Services);

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
