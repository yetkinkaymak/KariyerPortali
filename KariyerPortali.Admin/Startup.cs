using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KariyerPortali.Admin.Startup))]
namespace KariyerPortali.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
