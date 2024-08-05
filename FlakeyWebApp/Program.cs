var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/", () =>
{
    if (Random.Shared.Next(maxValue: 4) == 1) throw new Exception("Random exception");

    return "Hello World!";
});

app.MapDefaultEndpoints();
app.Run();
