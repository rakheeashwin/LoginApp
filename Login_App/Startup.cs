using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Login_App.Startup))]
namespace Login_App
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
