using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Roger.DataProcessAPI.Pages
{
    public class Index_Tests : DataProcessAPIWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
