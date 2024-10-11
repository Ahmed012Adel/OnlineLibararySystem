using Libarary.Domain.Contract;
using Library.Infrustructure.Persistent.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Library.Infrustructure.Persistent
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistentServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbcontext>(OptionBuilder =>
            OptionBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer(configuration.GetConnectionString("ApplicationDbContext"))
            );

            services.AddScoped(typeof(IApplicationContextIntializer), typeof(ApplicationIntializer));
            return services;
        }
    }
}
