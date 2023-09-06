using ApiEstudoTesteWebApplication.Infra.Context;

namespace ApiEstudoTesteWebApplication.IntegrationTests.Configuration
{
    public static class DataBaseFixtureTest
    {
        public static void PopulateTestData(DataBaseApiContext context)
        {
            context.Customer.Add(new("Caua", "111.222.333-44", DateTime.Parse("2000-01-01")));
            context.Customer.Add(new("Jeff", "222.222.222-22", DateTime.Parse("1980-01-01")));

            context.SaveChanges();
        }
    }
}
