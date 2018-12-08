using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PIDEV_MAP_MVC.Startup))]
namespace PIDEV_MAP_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
