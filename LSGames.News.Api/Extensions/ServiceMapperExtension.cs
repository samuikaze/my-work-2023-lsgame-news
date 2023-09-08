using LSGames.News.Api.Services;
using LSGames.News.Repository.Repositories;

namespace LSGames.News.Api.Extensions
{
    public class ServiceMapperExtension
    {
        public static IServiceCollection? GetServiceProvider(IServiceCollection? serviceCollection)
        {
            if (serviceCollection != null)
            {
                // Services
                serviceCollection.AddScoped<INewsService, NewsService>();

                // Repositories
                serviceCollection.AddScoped<INewsRepository, NewsRepository>();
                serviceCollection.AddScoped<INewsTypeRepository, NewsTypeRepository>();
            }

            return serviceCollection;
        }
    }
}
