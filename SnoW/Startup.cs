using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SnoW.Startup))]
namespace SnoW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
