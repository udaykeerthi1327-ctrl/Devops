// Program.cs - A simple ASP.NET 8 Minimal API
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content(@" 
   <!DOCTYPE html>
<html>
<head>
    <title>App Visualization</title>
    <style>
        body { font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; background-color: #f0f2f5; display: flex; justify-content: center; align-items: center; height: 100vh; margin: 0; }
        .card { background: white; padding: 2rem; border-radius: 12px; box-shadow: 0 4px 15px rgba(0,0,0,0.1); width: 350px; }
        .header { border-bottom: 2px solid #0078d4; padding-bottom: 10px; margin-bottom: 20px; }
        .status-pill { background: #dcfce7; color: #166534; padding: 4px 12px; border-radius: 20px; font-size: 0.85rem; font-weight: bold; }
        .info-row { display: flex; justify-content: space-between; margin: 10px 0; color: #4b5563; }
        .label { font-weight: 600; color: #1f2937; }
    </style>
</head>
<body>
    <div class='card'>
        <div class='header'>
            <h2 style='margin:0; color:#0078d4;'>Azure App Service</h2>
        </div>
        <div class='info-row'>
            <span class='label'>Status:</span>
            <span class='status-pill'>● Success</span>
        </div>
        <div class='info-row'>
            <span class='label'>Framework:</span>
            <span>.NET 8.0</span>
        </div>
        <div class='info-row'>
            <span class='label'>Region:</span>
            <span>East US</span>
        </div>
        <hr style='border: 0; border-top: 1px solid #eee; margin: 20px 0;'>
        <p style='font-size: 0.9rem; color: #666; text-align: center;'>Live API Visualization Mode</p>
    </div>
</body>
</html>
", "text/html"));

app.Run();
