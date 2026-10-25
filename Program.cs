var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/weather", () =>
{
    return Results.Ok(new
    {
        City = "Zagreb",
        Temperature = 18,
        Condition = "Sunny"
    });
});

app.Run();