using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OMEGA.Startup))]
namespace OMEGA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
