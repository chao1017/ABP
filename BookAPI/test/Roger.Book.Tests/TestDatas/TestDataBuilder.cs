using Roger.Book.EntityFrameworkCore;

namespace Roger.Book.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly BookDbContext _context;

        public TestDataBuilder(BookDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}