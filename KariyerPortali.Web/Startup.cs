using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KariyerPortali.Web.Startup))]
namespace KariyerPortali.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
