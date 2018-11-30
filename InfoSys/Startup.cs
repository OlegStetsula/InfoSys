using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InfoSys.Startup))]
namespace InfoSys
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
