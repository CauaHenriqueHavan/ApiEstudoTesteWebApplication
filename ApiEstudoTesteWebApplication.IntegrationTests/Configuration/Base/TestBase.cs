using NUnit.Framework;
using Xunit;

namespace ApiEstudoTesteWebApplication.IntegrationTests.Configuration.Base
{
    public abstract class TestBase
    {
        private TestWebApplicationFactory _testWebFactory;
        protected HttpClient _httpClient;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _testWebFactory = new TestWebApplicationFactory();
            _httpClient = _testWebFactory.CreateClient();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _httpClient.Dispose();
            _testWebFactory.Dispose();
        }
    }
}
