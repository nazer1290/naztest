using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(naztest.Startup))]
namespace naztest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
