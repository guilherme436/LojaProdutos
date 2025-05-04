var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

app.UseRouting();

app.MapRazorPages(); // Importante para mapear Razor Pages

app.Run();
