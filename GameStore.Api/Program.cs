using GameStore.Api.Data;
using GameStore.Api.Endpoints;


var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStore");

builder.Services.AddSqlite<GameStoreContext>(connString);


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Register the endpoints   
app.MapGamesEndpoints();

// Migrate the database
app.MigrateDb();


app.Run();
