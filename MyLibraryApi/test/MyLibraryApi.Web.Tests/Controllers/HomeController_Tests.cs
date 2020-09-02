using System.Threading.Tasks;
using MyLibraryApi.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyLibraryApi.Web.Tests.Controllers
{
    public class HomeController_Tests: MyLibraryApiWebTestBase
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
