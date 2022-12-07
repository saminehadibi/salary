using Microsoft.OpenApi.Models;

namespace Adibi.Web.Host.Startup
{
    internal class Info : OpenApiInfo
    {
        public string Title { get; set; }
        public string Version { get; set; }
    }
}