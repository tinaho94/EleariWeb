using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eleari.Startup))]
namespace Eleari
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
