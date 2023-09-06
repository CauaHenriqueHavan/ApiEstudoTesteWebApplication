using ApiEstudoTesteWebApplication.Infra.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ApiEstudoTesteWebApplication.IntegrationTests.Configuration
{
    public class TestWebApplicationFactory : WebApplicationFactory<Program>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                var serviceProvider = new ServiceCollection()
                                        .AddEntityFrameworkInMemoryDatabase()
                                        .BuildServiceProvider();

                services.AddScoped(sp =>
                {
                    return new DbContextOptionsBuilder<DataBaseApiContext>()
                    .UseInMemoryDatabase("TestDatabase")
                    .UseApplicationServiceProvider(sp)
                    .Options;
                });

                var sp = services.BuildServiceProvider();

                using var scope = sp.CreateScope();
                var scopedServices = scope.ServiceProvider;
                var appDb = scopedServices.GetRequiredService<DataBaseApiContext>();

                appDb.Database.EnsureCreated();

                try
                {
                    DataBaseFixtureTest.PopulateTestData(appDb);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex}");
                }
            });
        }
    }
}
