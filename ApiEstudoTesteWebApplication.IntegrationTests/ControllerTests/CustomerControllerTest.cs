using ApiEstudoTesteWebApplication.Domain.DTOs.OutputModel;
using ApiEstudoTesteWebApplication.IntegrationTests.Configuration.Base;
using Newtonsoft.Json;
using NUnit.Framework;

namespace ApiEstudoTesteWebApplication.IntegrationTests.Tests
{
    public class CustomerControllerTest : TestBase
    {
        [Test]
        public async Task GetCustomer_ShouldReturnSuccess()
        {
            //Arrange & Act
            var responseHttp = await _httpClient.GetAsync("api/Customer");

            var responseModel = JsonConvert.DeserializeObject<List<CustumerOutputModel>>(await responseHttp.Content.ReadAsStringAsync());
           
            //Assert
            Assert.True(responseHttp.IsSuccessStatusCode);
            Assert.NotNull(responseModel);
        }
    }
}