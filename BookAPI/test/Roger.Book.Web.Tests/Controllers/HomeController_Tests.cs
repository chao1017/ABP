using System.Threading.Tasks;
using Roger.Book.Web.Controllers;
using Shouldly;
using Xunit;

namespace Roger.Book.Web.Tests.Controllers
{
    public class HomeController_Tests: BookWebTestBase
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
