var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Welcome to .NET Web Application running in Browser!");
app.MapGet("/calculator", () => new {
    Addition = 10 + 5,
    Subtraction = 10 - 5,
    Multiplication = 10 * 5,
    Division = 10 / 5
});

app.Run();
