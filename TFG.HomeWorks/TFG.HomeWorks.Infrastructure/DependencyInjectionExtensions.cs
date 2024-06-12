using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TFG.HomeWorks.Application.ExternalServices;
using TFG.HomeWorks.Application.ExternalServices.Files;
using TFG.HomeWorks.Application.Repositories;
using TFG.HomeWorks.Application.Services.Authentication;
using TFG.HomeWorks.Infrastructure.ExternalServices;
using TFG.HomeWorks.Infrastructure.Options;
using TFG.HomeWorks.Infrastructure.Persistance;
using TFG.HomeWorks.Infrastructure.Persistance.Queries;
using TFG.HomeWorks.Infrastructure.Persistance.Repositories;

namespace TFG.HomeWorks.Infrastructure
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>((sp, options) =>
            {
                var configuration = sp.GetRequiredService<IConfiguration>();
                options.UseSqlServer(configuration.GetConnectionString("ApplicationDbContext"));

            });
            services.AddScoped<DbConnectionFactory>();
            services.AddScoped(sp => sp.GetRequiredService<DbConnectionFactory>().GetDbConnection(DbConnectionEnum.APP));

            services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<ApplicationDbContext>());

            services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();

            services.AddScoped<IExternalService, DapperQueryExternalService>();

            // ToDo: Configurar desde alguna sección de appsettings
            // ToDo: Valorar forma genérica para configurar todos los httpclients de la misma forma
            services.AddHttpClient<IMyIpService, Myipcom_MyIPService>(client =>
            {
                client.BaseAddress = new Uri("https://api.myip.com");
            });

            //IOptions
            services.AddOptions<FileStorageFilePaths>().BindConfiguration(nameof(FileStorageFilePaths));

            //Common
            services.AddScoped<IFileStorageService, LocalFileStorageService>();

            //Authentication
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            services.AddScoped<ISaltGenerator, SaltGenerator>();
            services.AddScoped<IUserRepository, UserRepository>();

            //House
            services.AddScoped<IHouseRepository, HouseRepository>();

            //Tasks
            services.AddScoped<ITaskRepository, TaskRepository>();

            return services;
        }
    }
}
