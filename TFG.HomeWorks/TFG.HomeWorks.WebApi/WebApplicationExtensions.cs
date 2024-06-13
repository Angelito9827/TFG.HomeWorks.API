using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

namespace TFG.HomeWorks.WebApi
{
    public static class WebApplicationExtensions
    {
        public static void Configure(this WebApplication app)
        {
            if (!app.Environment.IsProduction())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseExceptionHandler();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
