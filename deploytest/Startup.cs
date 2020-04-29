using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(deploytest.Startup))]
namespace deploytest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
