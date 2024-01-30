using Microsoft.AspNetCore.Mvc;

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

app.MapGet("/configs/{file}", ([FromRoute] string file) =>
    {
        if (!File.Exists(Path.Combine("configs", file)))
            return Results.NotFound();
        else
        {
            return Results.Stream(new FileStream(Path.Combine("configs", file), FileMode.Open));
        }
    })
.WithName("GetWeatherForecast");

app.Run();
