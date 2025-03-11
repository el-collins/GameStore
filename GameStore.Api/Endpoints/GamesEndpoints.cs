using GameStore.Api.Dtos;

namespace GameStore.Api.Endpoints;

public static class GamesEndpoints
{

    private static readonly List<GameDto> games = new()
{
    new GameDto(1, "The Last of Us Part II", "Action", 59.99m, new DateOnly(2020, 6, 19)),
    new GameDto(2, "Ghost of Tsushima", "Action", 59.99m, new DateOnly(2020, 7, 17)),
    new GameDto(3, "Cyberpunk 2077", "RPG", 59.99m, new DateOnly(2020, 12, 10))
};


    public static RouteGroupBuilder MapGamesEndpoints(this WebApplication app)
    {

        var group = app.MapGroup("games");

        group.MapGet("/", () => games);  // Return the list of games

        // Return a game by id
        group.MapGet("/{id}", (int id) => games.Find(g => g.Id == id));

        // POST - Add a new game
        group.MapPost("games", (CreateGameDto game) =>
        {
            // validation logic
            if (string.IsNullOrEmpty(game.Name))
            {
                return Results.BadRequest("Name is required");
            }



            int newId = games.Max(g => g.Id) + 1;
            var newGame = new GameDto(newId, game.Name, game.Genre, game.Price, game.ReleaseDate);
            games.Add(newGame);
            return Results.Created($"/games/{newId}", newGame);
        }).WithParameterValidation();

        // PUT - Update a game
        group.MapPut("/{id}", (int id, UpdateGameDto game) =>
        {
            var existingGame = games.Find(g => g.Id == id);
            if (existingGame == null)
            {
                return Results.NotFound();
            }

            var updatedGame = new GameDto(
                   existingGame.Id,
                   game.Name,
                   game.Genre,
                   game.Price,
                   game.ReleaseDate
               );

            var index = games.FindIndex(g => g.Id == id);
            games[index] = updatedGame;

            return Results.NoContent();

        });


        // DELETE - Delete a game
        group.MapDelete("/{id}", (int id) =>
        {
            var existingGame = games.Find(g => g.Id == id);
            if (existingGame == null)
            {
                return Results.NotFound();
            }

            games.Remove(existingGame);
            return Results.NoContent();
        });

        return group;
    }
}
