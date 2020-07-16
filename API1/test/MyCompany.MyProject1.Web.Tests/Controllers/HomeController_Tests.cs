using System.Threading.Tasks;
using MyCompany.MyProject1.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyCompany.MyProject1.Web.Tests.Controllers
{
    public class HomeController_Tests: MyProject1WebTestBase
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
