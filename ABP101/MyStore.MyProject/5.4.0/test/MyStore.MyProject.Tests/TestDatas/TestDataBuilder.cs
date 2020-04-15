using MyStore.MyProject.EntityFrameworkCore;

namespace MyStore.MyProject.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly MyProjectDbContext _context;

        public TestDataBuilder(MyProjectDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}