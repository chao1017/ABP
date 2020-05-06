﻿using System;
using System.Threading.Tasks;
using Abp.TestBase;
using Roger.SimpleTaskSystem.EntityFrameworkCore;
using Roger.SimpleTaskSystem.Tests.TestDatas;

namespace Roger.SimpleTaskSystem.Tests
{
    public class SimpleTaskSystemTestBase : AbpIntegratedTestBase<SimpleTaskSystemTestModule>
    {
        public SimpleTaskSystemTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<SimpleTaskSystemDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<SimpleTaskSystemDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<SimpleTaskSystemDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<SimpleTaskSystemDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<SimpleTaskSystemDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<SimpleTaskSystemDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<SimpleTaskSystemDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<SimpleTaskSystemDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}