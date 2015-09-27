using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SizePlay.Startup))]
namespace SizePlay
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
