var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => 
{
    var todo = new Todo(Guid.NewGuid(), "Run", false);
    return Results.Ok();
});

app.Run();
