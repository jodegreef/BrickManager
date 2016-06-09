using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrickManager.Web.Startup))]
namespace BrickManager.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
