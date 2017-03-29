using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarantPropertiesLLC.Startup))]
namespace MarantPropertiesLLC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
