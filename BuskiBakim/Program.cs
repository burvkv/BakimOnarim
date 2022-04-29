using bakimonarim.dataaccess.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BakimOnarimDbContext>(
    options => options.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=bakimonarimdb;Trusted_Connection=True;")
    );
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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
       name: "login",
       pattern: "login",
       defaults: new { controller = "auth", action = "login" }
       );
    endpoints.MapControllerRoute(
       name: "register",
       pattern: "register",
       defaults: new { controller = "auth", action = "register" }
       );
    endpoints.MapControllerRoute(
       name: "panel",
       pattern: "index",
       defaults: new { controller = "panel", action = "index" }
       );
    endpoints.MapControllerRoute(
        name:"landing",
        pattern:"landing",
        defaults: new {controller = "landing", action = "index"}
        );
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=landing}/{action=index}/{id?}"
        );

});

app.Run();
