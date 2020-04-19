﻿using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Roger.SimpleTaskSystem.EntityFrameworkCore
{
    [DependsOn(
        typeof(SimpleTaskSystemCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class SimpleTaskSystemEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SimpleTaskSystemEntityFrameworkCoreModule).GetAssembly());
        }
    }
}