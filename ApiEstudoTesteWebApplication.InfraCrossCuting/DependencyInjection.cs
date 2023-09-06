using ApiEstudoTesteWebApplication.Domain.Interface.Repository;
using ApiEstudoTesteWebApplication.Domain.Interface.Service;
using ApiEstudoTesteWebApplication.Infra.Context;
using ApiEstudoTesteWebApplication.Infra.Repository;
using ApiEstudoTesteWebApplication.Service.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ApiEstudoTesteWebApplication.InfraCrossCuting
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureDependecyInjection(this IServiceCollection service)
            => service
                    .AddDbContext<DataBaseApiContext>(x => x.UseSqlite("Data source=databaseLocal.db"))
                    .ConfigureService()
                    .ConfigureRepository();

        public static IServiceCollection ConfigureService(this IServiceCollection service)
            => service.AddTransient<ICustomerService, CustomerService>();

        public static IServiceCollection ConfigureRepository(this IServiceCollection service)
            => service.AddTransient<ICustomerRepository, CustomerRepository>();
    }
}