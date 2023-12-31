

using ComputerHardwareECommerceApi.Application.DataServices;
using ComputerHardwareECommerceApi.Application.Mapping;
using ComputerHardwareECommerceApi.Infrastructure.DataServices;
using Microsoft.Extensions.DependencyInjection;

namespace ComputerHardwareECommerceApi.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureService(this IServiceCollection service)
        {
            service.AddScoped(typeof(IDataService<,>),typeof(DataService<,>));
            service.AddScoped<IProductDataService, ProductDataService>();
            service.AddAutoMapper(typeof(ShoppingCartProfile));
        }
    }
}
