using System;
using System.Threading.Tasks;
using Abp.TestBase;
using Roger.Book.EntityFrameworkCore;
using Roger.Book.Tests.TestDatas;

namespace Roger.Book.Tests
{
    public class BookTestBase : AbpIntegratedTestBase<BookTestModule>
    {
        public BookTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<BookDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<BookDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<BookDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<BookDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<BookDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<BookDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<BookDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<BookDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
