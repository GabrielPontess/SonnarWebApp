using Microsoft.EntityFrameworkCore;
using Sonnar.Domain.Interfaces;
using Sonnar.Infrastructure;
using Sonnar.Infrastructure.Repositories;
using Sonnar.Infrastructure.UoW;
using Sonnar.WebApp.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string connectionString = "Server=RN0990\\MSSQLSERVER01;Database=SonnarDb;Integrated Security=SSPI; MultipleActiveResultSets=true";
builder.Services.AddDbContext<SonnarDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();
builder.Services.AddScoped<IUnitOfWork, UnityOfWork>();
builder.Services.AddScoped<Sonnar.WebApp.Helpers.ISession, Session>();

builder.Services.AddSession(o =>
{
    o.Cookie.HttpOnly= true;
    o.Cookie.IsEssential = true;
});



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

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
