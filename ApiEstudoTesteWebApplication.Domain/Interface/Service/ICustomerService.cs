using ApiEstudoTesteWebApplication.Domain.DTOs.OutputModel;

namespace ApiEstudoTesteWebApplication.Domain.Interface.Service
{
    public interface ICustomerService
    {
        public Task<List<CustumerOutputModel>> GetCustomerAsync();
    }
}
