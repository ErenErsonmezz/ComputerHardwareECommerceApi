using ComputerHardwareECommerceApi.Application.Repositories;
using ComputerHardwareECommerceApi.Application.UnitOfWorks;
using ComputerHardwareECommerceApi.Persistence.Contexts;
using ComputerHardwareECommerceApi.Persistence.Repositories;
using ComputerHardwareECommerceApi.Persistence.Repositories.ProductRepositories;
using ComputerHardwareECommerceApi.Persistence.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ComputerHardwareECommerceApi.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection service)
        {
          
            service.AddScoped(typeof(IReadRepository<>),typeof(ReadRepository<>));
            service.AddScoped(typeof(IWriteRepository<>),typeof(WriteRepository<>));
            service.AddScoped<IProductReadRepository,ProductReadRepository>();
            service.AddScoped<IUnitOfWork,UnitOfWork>();
            service.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(Configuration.ConnectionString);
            });
        }
    }
}
