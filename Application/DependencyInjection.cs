using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    /// <summary>
    /// injection des dependance lier a ma couche application
    /// </summary>
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}
