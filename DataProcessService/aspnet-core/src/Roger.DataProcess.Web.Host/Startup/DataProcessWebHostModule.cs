using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Roger.DataProcess.Configuration;

namespace Roger.DataProcess.Web.Host.Startup
{
    [DependsOn(
       typeof(DataProcessWebCoreModule))]
    public class DataProcessWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DataProcessWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DataProcessWebHostModule).GetAssembly());
        }
    }
}
