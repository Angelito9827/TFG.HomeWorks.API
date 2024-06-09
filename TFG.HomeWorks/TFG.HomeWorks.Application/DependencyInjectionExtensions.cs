using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using TFG.HomeWorks.Application.Mapping;
using TFG.HomeWorks.Application.Options;
using TFG.HomeWorks.Application.Services.Authentication;
using TFG.HomeWorks.Application.Services.House;
using TFG.HomeWorks.Application.Services.Sample;
using TFG.HomeWorks.Application.Services.WeatherForecast;
using TFG.HomeWorks.Application.Validations;

namespace TFG.HomeWorks.Application
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddValidations();
            services.AddAutoMapper(x => x.AddProfile<MappingProfile>());
            services.AddAutoMapper(x => x.AddMaps(typeof(DependencyInjectionExtensions).Assembly));

            services.AddOptions<ApplicationSettings>().BindConfiguration(nameof(ApplicationSettings));
            services.AddOptions<ApiUrls>().BindConfiguration(nameof(ApiUrls));


            services.AddScoped<IWeatherForecastService, WeatherForecastService>();
            services.AddScoped<ISampleService, SampleService>();

            //Authentication
            services.AddScoped<IAuthService, AuthService>();

            //House
            services.AddScoped<IHouseService, HouseService>();

            return services;
        }

        private static IServiceCollection AddValidations(this IServiceCollection services)
        {
            // Esta extensión carga todas las implementaciones de IValidator y las inyecto como servicio con ciclo de vida Scope
            services.AddValidatorsFromAssemblyContaining<ApplicationObjectValidator>(ServiceLifetime.Singleton);
            // Se añade con ciclo de vida scope para que coincida con el ciclo de vida de los validadores cargados con AddValidatorsFromAssemblyContaining
            services.AddScoped<IObjectValidator, ApplicationObjectValidator>();

            return services;
        }
    }
}
