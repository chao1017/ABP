using MyLibraryApi.EntityFrameworkCore;

namespace MyLibraryApi.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly MyLibraryApiDbContext _context;

        public TestDataBuilder(MyLibraryApiDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}