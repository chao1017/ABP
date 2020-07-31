using Microsoft.OpenApi.Models;

namespace Roger.Api1.Web.Startup
{
    internal class Info : OpenApiInfo
    {
        public string Title { get; set; }
        public string Version { get; set; }
    }
}