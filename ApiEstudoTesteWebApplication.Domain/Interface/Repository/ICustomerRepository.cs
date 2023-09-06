using ApiEstudoTesteWebApplication.Domain.DTOs.OutputModel;

namespace ApiEstudoTesteWebApplication.Domain.Interface.Repository
{
    public interface ICustomerRepository
    {
        Task<List<CustumerOutputModel>> GetCustomerAsync();
    }
}
