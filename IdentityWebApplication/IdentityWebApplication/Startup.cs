using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityWebApplication.Startup))]
namespace IdentityWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}