using GameStore.Api.Endpoints;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Register the endpoints   
app.MapGamesEndpoints();




app.Run();
