using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ntpstone.Startup))]
namespace ntpstone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
