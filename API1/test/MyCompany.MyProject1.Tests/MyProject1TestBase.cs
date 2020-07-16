using System;
using System.Threading.Tasks;
using Abp.TestBase;
using MyCompany.MyProject1.EntityFrameworkCore;
using MyCompany.MyProject1.Tests.TestDatas;

namespace MyCompany.MyProject1.Tests
{
    public class MyProject1TestBase : AbpIntegratedTestBase<MyProject1TestModule>
    {
        public MyProject1TestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<MyProject1DbContext> action)
        {
            using (var context = LocalIocManager.Resolve<MyProject1DbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<MyProject1DbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyProject1DbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<MyProject1DbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<MyProject1DbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<MyProject1DbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyProject1DbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
