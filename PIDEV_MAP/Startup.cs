using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PIDEV_MAP.Startup))]
namespace PIDEV_MAP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
