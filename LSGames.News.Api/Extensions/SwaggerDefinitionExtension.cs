using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace LSGames.News.Api.Extensions
{
    public class SwaggerDefinitionExtension
    {
        public static IServiceCollection ConfigureSwagger(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSwaggerGen(config =>
            {
                var filePath = Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetEntryAssembly()?.GetName().Name}.xml");
                config.IncludeXmlComments(filePath);
                config.EnableAnnotations();
            });

            return serviceCollection;
        }
    }
}
