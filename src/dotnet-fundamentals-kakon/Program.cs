using dotnet_fundamentals_kakon.Routes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.MapGameEndpoints();
app.Run();