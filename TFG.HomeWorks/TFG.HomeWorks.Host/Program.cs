using Microsoft.EntityFrameworkCore;
using Serilog;
using TFG.HomeWorks.Application;
using TFG.HomeWorks.Infrastructure;
using TFG.HomeWorks.Infrastructure.Persistance;

namespace TFG.HomeWorks.WebApi.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services
                .AddApiServices()
                .AddApplicationServices()
                .AddInfrastructureServices();

            builder.Host.UseSerilog((context, config) => config.ReadFrom.Configuration(context.Configuration));

            var app = builder.Build();

            app.UseSerilogRequestLogging(options => options.IncludeQueryInRequestPath = true);

            // Habilitar para proyectos con Frontend + Backend
            //app.UseStaticFiles();
            // FOR DEBUG
            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = new Microsoft.Extensions.FileProviders.PhysicalFileProvider(
            //        Path.Combine(new DirectoryInfo(builder.Environment.ContentRootPath)!.Parent!.Parent!.FullName,
            //            "site", "dist", "portal-de-clientes")
            //    )
            //});

            app.Configure();

            // Habilitar para proyectos con Frontend+Backend
            //app.MapFallbackToFile("index.html");
            // FOR DEBUG
            //app.MapFallback(x =>
            //    x.Response.SendFileAsync(Path.Combine(
            //        new DirectoryInfo(builder.Environment.ContentRootPath)!.Parent!.Parent!.FullName, "site"
            //        , "dist", "portal-de-clientes", "index.html")));

#warning Esto es para fines de demostración y poder probar la plantilla
            EnsureDatabaseCreated(app);
            // Para ejecutar las migraciones automáticamente
            //EnsureDatabaseUpdated(scope.ServiceProvider);

            app.Run();
        }
        private static void EnsureDatabaseCreated(WebApplication app)
        {
            var scope = app.Services.CreateScope();
            var applicationDbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

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
        private static void EnsureDatabaseUpdated(WebApplication app)
        {
            var scope = app.Services.CreateScope();
            var applicationDbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

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
}