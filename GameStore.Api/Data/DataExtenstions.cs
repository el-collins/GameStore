
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data;

public static class DataExtenstions
{
    public static void MigrateDb(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        using var context = scope.ServiceProvider.GetRequiredService<GameStoreContext>();
        context.Database.Migrate();
    }

}
