using Microsoft.EntityFrameworkCore;
using TFG.HomeWorks.Infrastructure.Persistance;
using TFG.HomeWorks.WebApi.Host;

internal static class ProgramHelpers
{
    public static void CreateDatabase(this IHost app)
    {
        using var scope = app.Services.CreateScope();

        EnsureDatabaseCreated(scope.ServiceProvider);
    }

    private static void EnsureDatabaseCreated(IServiceProvider services)
    {
        var applicationDbContext = services.GetRequiredService<ApplicationDbContext>();
        var logger = services.GetRequiredService<ILogger<Program>>();

        try
        {
            applicationDbContext.Database.EnsureCreated();
        }
        catch
        {
            logger.LogError("No se ha podido crear la base de datos");
            throw;
        }
    }

    public static void UpdateDatabase(this IHost app)
    {
        using var scope = app.Services.CreateScope();

        EnsureDatabaseUpdated(scope.ServiceProvider);
    }

    private static void EnsureDatabaseUpdated(IServiceProvider services)
    {
        var applicationDbContext = services.GetRequiredService<ApplicationDbContext>();
        var logger = services.GetRequiredService<ILogger<Program>>();

        try
        {
            applicationDbContext.Database.Migrate();
        }
        catch
        {
            logger.LogError("No se ha podido actualizar la base de datos");
            throw;
        }
    }
}