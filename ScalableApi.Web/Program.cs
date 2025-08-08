using Scalar.AspNetCore;
using Services;
using Services.Implementations;
using Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddKeyedSingleton<IFibonacciService, LinearFibonacciService>(nameof(LinearFibonacciService))
    .AddKeyedSingleton<IFibonacciService, RecursiveFibonacciService>(nameof(RecursiveFibonacciService));

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();