using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Serialization;
using TFG.HomeWorks.Application.Security;
using TFG.HomeWorks.WebApi.Filters;
using TFG.HomeWorks.WebApi.Services;
using TFG.HomeWorks.WebApi.Swagger;

namespace TFG.HomeWorks.WebApi
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            services.AddScoped<ICurrentUserAccessor, CurrentUserAccessor>();

            services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                })
                .ConfigureApiBehaviorOptions(options =>
                {
                    // https://learn.microsoft.com/es-es/dotnet/core/compatibility/aspnet-core/7.0/api-controller-action-parameters-di
                    options.DisableImplicitFromServicesParameters = true;
                });

            services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

            services.AddExceptionHandler<HttpGlobalExceptionHandler>();
            services.AddProblemDetails();

            services.AddSwaggerGen(SwaggerGenHelpers.Configure);

            services.AddAuthentication().AddJwtBearer();
            services.AddAuthorization();
            services.AddHttpContextAccessor();

            services.AddSingleton<IContentTypeProvider, FileExtensionContentTypeProvider>();

            return services;
        }
    }
}
