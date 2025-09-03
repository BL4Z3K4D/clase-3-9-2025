using Acme.Hello.Platform.Generic.Domain.Intefaces.REST.Assemblers;
using Acme.Hello.Platform.Generic.Domain.Intefaces.REST.Resources;
using Acme.Hello.Platform.Generic.Domain.Model.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/greetings", (string? firstname, string? lastName) =>
    {
        var developer = !string.IsNullOrWhiteSpace(firstname)  || !string.IsNullOrWhiteSpace(lastName) ? new Developer(firstName, lastName) : null;
        var response = GreetDeveloperResponseAssembler.ToResponseFromEntity(developer);
        return Results.Ok(response);
    })
    .WithName("GetWeatherForecast")
    .WithOpenApi();
app.MapPost("/greetings", (GreetDeveloperRequest request) =>
{
    var developer = DeveloperAssembler.ToEntityFromRequest(request);
    var response = GreetDeveloperResponseAssembler.ToResponseFromEntity(developer);
        return Results.Created("/greetings", response);
})
.WithName("CreateGreeting")
.WithOpenApi();
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}