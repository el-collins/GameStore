using GameStore.Api.Dtos;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games = new()
{
    new GameDto(1, "The Last of Us Part II", "Action", 59.99m, new DateOnly(2020, 6, 19)),
    new GameDto(2, "Ghost of Tsushima", "Action", 59.99m, new DateOnly(2020, 7, 17)),
    new GameDto(3, "Cyberpunk 2077", "RPG", 59.99m, new DateOnly(2020, 12, 10))
};

app.MapGet("games", () => games);  // Return the list of games

// Return a game by id
app.MapGet("games/{id}", (int id) => games.Find(g => g.Id == id));

// POST - Add a new game
app.MapPost("games", (CreateGameDto game) =>
{
    int newId = games.Max(g => g.Id) + 1;
    var newGame = new GameDto(newId, game.Name, game.Genre, game.Price, game.ReleaseDate);
    games.Add(newGame);
    return Results.Created($"/games/{newId}", newGame);
});

app.Run();
