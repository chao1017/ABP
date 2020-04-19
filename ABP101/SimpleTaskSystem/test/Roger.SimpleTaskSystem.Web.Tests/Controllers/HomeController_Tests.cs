using System.Threading.Tasks;
using Roger.SimpleTaskSystem.Web.Controllers;
using Shouldly;
using Xunit;

namespace Roger.SimpleTaskSystem.Web.Tests.Controllers
{
    public class HomeController_Tests: SimpleTaskSystemWebTestBase
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
