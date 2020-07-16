using MyCompany.MyProject1.EntityFrameworkCore;

namespace MyCompany.MyProject1.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly MyProject1DbContext _context;

        public TestDataBuilder(MyProject1DbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}