using Microsoft.VisualBasic.CompilerServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Roger.Api1.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddIdentityCore<User>().AddDefaultTokenProviders();
        }
    }
}
