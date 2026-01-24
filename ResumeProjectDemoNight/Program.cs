using Microsoft.EntityFrameworkCore;
using ResumeProjectDemoNight.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ResumeContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

/* 🔥 BU SATIR YOKTU → SORUN BUYDU */
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
