﻿using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyStore.MyProject.EntityFrameworkCore
{
    [DependsOn(
        typeof(MyProjectCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class MyProjectEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProjectEntityFrameworkCoreModule).GetAssembly());
        }
    }
}