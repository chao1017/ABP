using System;
using System.Threading.Tasks;
using Abp.TestBase;
using MyLibraryApi.EntityFrameworkCore;
using MyLibraryApi.Tests.TestDatas;

namespace MyLibraryApi.Tests
{
    public class MyLibraryApiTestBase : AbpIntegratedTestBase<MyLibraryApiTestModule>
    {
        public MyLibraryApiTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<MyLibraryApiDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<MyLibraryApiDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<MyLibraryApiDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyLibraryApiDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<MyLibraryApiDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<MyLibraryApiDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<MyLibraryApiDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyLibraryApiDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
