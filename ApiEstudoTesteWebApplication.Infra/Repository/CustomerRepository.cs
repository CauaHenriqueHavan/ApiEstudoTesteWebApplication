using ApiEstudoTesteWebApplication.Domain.DTOs.OutputModel;
using ApiEstudoTesteWebApplication.Domain.Interface.Repository;
using ApiEstudoTesteWebApplication.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiEstudoTesteWebApplication.Infra.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataBaseApiContext _context;

        public CustomerRepository(DataBaseApiContext context)
            => _context = context;

        public async Task<List<CustumerOutputModel>> GetCustomerAsync()
            => await _context.Customer
                                .Select(c => new CustumerOutputModel
                                {
                                    BirthDate = c.BirthDate,
                                    Document = c.Document,
                                    Id = c.Id,
                                    Name = c.Name
                                })
                                .ToListAsync();
    }
}
