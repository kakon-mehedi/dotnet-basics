var builder = WebApplication.CreateBuilder(args);

// Adding controllers for returing views in Routing
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Adding Convention based Routing
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(name: "api", pattern: "v1/api/{controller}/{action=Index}/{id?}");

// Adding Attribute based routing 
app.MapControllers();
app.Run();