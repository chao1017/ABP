using System.Threading.Tasks;
using Roger.Api1.Web.Controllers;
using Shouldly;
using Xunit;

namespace Roger.Api1.Web.Tests.Controllers
{
    public class HomeController_Tests: Api1WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
