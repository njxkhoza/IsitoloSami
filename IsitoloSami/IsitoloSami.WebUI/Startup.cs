using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IsitoloSami.WebUI.Startup))]
namespace IsitoloSami.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
