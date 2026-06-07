using MVC.Store;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ProductStore>();

var app = builder.Build();

app.UseRouting();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=products}/{action=index}/{id?}"
);

app.Run();
