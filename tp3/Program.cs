using tp3.Models;
using tp3.Models.repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Enregistrer le repository
builder.Services.AddSingleton<repository<Employe>, EmployeRepository>();

var app = builder.Build();

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
    pattern: "{controller=Employee}/{action=Index}/{id?}");

app.Run();