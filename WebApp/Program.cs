using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();
builder.AddNpgsqlDbContext<AppDbContext>("db");

var app = builder.Build();

app.MapGet("/", async (AppDbContext db) =>
{
    await db.Database.EnsureCreatedAsync();

    var product = new Product();

    await db.Products.AddAsync(product);
    await db.SaveChangesAsync();

    return await db.Products.ToListAsync();
});

app.MapGet("/backend", (HttpClient client) =>
{
    return client.GetStringAsync("http://backend");
});

app.MapDefaultEndpoints();

app.Run();


class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();
}

public class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();
}