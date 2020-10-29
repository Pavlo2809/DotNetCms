using DotNetCms.Core.Abstractions.Repositories;
using DotNetCms.DataLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetCms.DataLayer
{
    public static class DataLayerStartup
    {
        public static void AddDatalayer(this IServiceCollection services)
        {
            services.AddTransient<IBlogRepository, BlogRepository>();
            services.AddTransient<ICarouselItemRepository, CarouselItemRepository>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IHumanRepository, HumanRepository>();
            services.AddTransient<IPossitionRepository, PossitionRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<ISocialNetworkRepository, SocialNetworkRepository>();
            services.AddTransient<ITariffRepository, TariffRepository>();
        }
    }
}