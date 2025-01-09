using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using tt0103.Models;

var builder = WebApplication.CreateBuilder(args);

Batteries.Init();
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ESQtempdatabasedbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
