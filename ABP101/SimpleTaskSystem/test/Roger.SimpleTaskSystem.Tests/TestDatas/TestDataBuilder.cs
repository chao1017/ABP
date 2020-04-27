using Roger.SimpleTaskSystem.EntityFrameworkCore;
using Roger.SimpleTaskSystem.Tasks;

namespace Roger.SimpleTaskSystem.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly SimpleTaskSystemDbContext _context;

        public TestDataBuilder(SimpleTaskSystemDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
            _context.Tasks.AddRange(
            new Task("Follow the white rabbit", "Follow the white rabbit in order to know the reality."),
            new Task("Clean your room") { State = TaskState.Completed }
            );
        }
    }
}