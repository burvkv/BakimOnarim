using Autofac;
using Autofac.Extensions.DependencyInjection;
using bakimonarim.business.Abstracts;
using bakimonarim.business.Concrete;
using bakimonarim.business.DependencyResolvers.Autofac;
using bakimonarim.business.Helpers.MailHelper;
using bakimonarim.core.DependencyResolvers;
using bakimonarim.core.Extensions.ServiceCollectionExtensions;
using bakimonarim.core.Utilities.Interceptors;
using bakimonarim.core.Utilities.IoC;
using bakimonarim.dataaccess.Abstract;
using bakimonarim.dataaccess.Concrete;
using Castle.DynamicProxy;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvc().AddNewtonsoftJson(options =>
    options.SerializerSettings.ContractResolver = new DefaultContractResolver()
);


builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacBusinessModule());
});


builder.Services.AddDependencyResolvers(new ICoreModule[]
{
    new CoreModule()
});


builder.Services.AddDbContext<BakimOnarimDbContext>();
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
       name: "panel/gruplar",
       pattern: "panel/gruplar",
       defaults: new { controller = "Gruplar", action = "index" }
       );
    endpoints.MapControllerRoute(
       name: "panel/varliklar",
       pattern: "panel/varliklar",
       defaults: new { controller = "Varliklar", action = "index" }
       );
    endpoints.MapControllerRoute(
       name: "panel/giris-yap",
       pattern: "panel/giris-yap",
       defaults: new { controller = "auth", action = "login" }
       );
    endpoints.MapControllerRoute(
       name: "panel/kayit-ol",
       pattern: "panel/kayit-ol",
       defaults: new { controller = "auth", action = "register" }
       );
    endpoints.MapControllerRoute(
       name: "panel",
       pattern: "panel",
       defaults: new { controller = "panel", action = "index" }
       );
    endpoints.MapControllerRoute(
        name:"landing",
        pattern:"landing",
        defaults: new {controller = "landing", action = "index"}
        );
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=panel}/{action=index}/{id?}"
        );

});

app.Run();
