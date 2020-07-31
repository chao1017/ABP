using Roger.Api1.EntityFrameworkCore;

namespace Roger.Api1.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly Api1DbContext _context;

        public TestDataBuilder(Api1DbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}