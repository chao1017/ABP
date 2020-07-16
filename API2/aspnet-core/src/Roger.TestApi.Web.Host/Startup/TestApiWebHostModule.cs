using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Roger.TestApi.Configuration;

namespace Roger.TestApi.Web.Host.Startup
{
    [DependsOn(
       typeof(TestApiWebCoreModule))]
    public class TestApiWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TestApiWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TestApiWebHostModule).GetAssembly());
        }
    }
}
