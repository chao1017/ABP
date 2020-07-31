using System;
using System.Threading.Tasks;
using Abp.TestBase;
using Roger.Api1.EntityFrameworkCore;
using Roger.Api1.Tests.TestDatas;

namespace Roger.Api1.Tests
{
    public class Api1TestBase : AbpIntegratedTestBase<Api1TestModule>
    {
        public Api1TestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<Api1DbContext> action)
        {
            using (var context = LocalIocManager.Resolve<Api1DbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<Api1DbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<Api1DbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<Api1DbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<Api1DbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<Api1DbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<Api1DbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
