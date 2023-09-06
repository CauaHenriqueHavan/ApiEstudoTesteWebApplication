using ApiEstudoTesteWebApplication.Domain.DTOs.OutputModel;
using ApiEstudoTesteWebApplication.Domain.Interface.Repository;
using ApiEstudoTesteWebApplication.Domain.Interface.Service;

namespace ApiEstudoTesteWebApplication.Service.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
            => _customerRepository = customerRepository;

        public async Task<List<CustumerOutputModel>> GetCustomerAsync()
            => await _customerRepository.GetCustomerAsync();
    }
}
