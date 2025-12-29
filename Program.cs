// Program.cs - A simple ASP.NET 8 Minimal API
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new { 
    Message = "Hello from Azure App Service!", 
    Framework = ".NET 8",
    Status = "Success" 
});

app.Run();