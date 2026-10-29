using Application_csharp.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddHealthChecks();
builder.Services.AddSingleton<CardStore>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.MapHealthChecks("/health");
app.MapGet("/cards/{id}", (string id, CardStore cardStore) =>
{
    if (cardStore.TryGet(id, out var card))
    {
        return Results.Ok(card);
    }
    return Results.NotFound(new { error = "Cartão não encontrado"});
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
