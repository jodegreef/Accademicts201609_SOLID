using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IoCWeb.Startup))]
namespace IoCWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
