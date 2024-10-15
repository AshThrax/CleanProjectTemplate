using Application;
using Application.Common;
using Infrastructure.Persistence;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    /// <summary>
    /// injection des service lier a l'implementation de mes services
    /// </summary>
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,IConfiguration configuration )
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddRepositoryService();
            services.AddApplcationDbContext(configuration);
            return services;
        }
        /// <summary>
        /// injection de la base de donnée 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddApplcationDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(context =>
            {
                context.UseSqlServer(configuration.GetConnectionString("Default"));
            });

            return services;
        }
        /// <summary>
        /// injection des repository 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRepositoryService(this IServiceCollection services)
        {
            services.AddScoped<ISubToDoDItemRepository, SubToDoItemRepository>();
            services.AddScoped<IToDoItemRepository, TodoItemRepository>();
            return services;
        }
    }
}
