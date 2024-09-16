var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //mvcde kullanacaðýmýz views ve controllerlarý ekledik.

var app = builder.Build();

app.UseStaticFiles();

//app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.Run();
