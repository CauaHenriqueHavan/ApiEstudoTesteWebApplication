using ApiEstudoTesteWebApplication.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace ApiEstudoTesteWebApplication.Infra.Context
{
    public class DataBaseApiContext : DbContext
    {
        public DbSet<CustomerEntity> Customer { get; set; }

        public DataBaseApiContext(DbContextOptions<DataBaseApiContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
