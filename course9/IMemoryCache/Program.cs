using Microsoft.Extensions.Caching.Memory;
IMemoryCache cache = new MemoryCache(new MemoryCacheOptions { SizeLimit = 1024 });

cache.Set("ProductList", new List<string> { "Product1", "Product2" }, 
    new MemoryCacheEntryOptions
    {
        AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5),
        Size = 1
    });

if (!cache.TryGetValue("ProductList", out List<string>? products))
        {
            Console.WriteLine("Cache miss. Fetching data...");
            products = new List<string> { "Product1", "Product2", "Product3" }; // Simulate fetching data
        
            cache.Set("ProductList", products, new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5),
                Size = 1
            });
            Console.WriteLine("Data added to cache.");
        }
        else
        {
            Console.WriteLine("Cache hit. Data retried from cache");
        }
Console.WriteLine($"Cached Data: {string.Join(", ", products)}");
Console.WriteLine("Removing 'ProductList' from cache...");
        cache.Remove("ProductList");
        if (!cache.TryGetValue("ProductList", out _))
        {
            Console.WriteLine("Cache entry 'ProductList' successfully removed.");
        }
        else
        {
            Console.WriteLine("Cache entry 'ProductList' still exists.");
        }

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
