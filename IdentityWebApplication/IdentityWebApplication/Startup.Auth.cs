using IdentityWebApplication.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace IdentityWebApplication
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            //1要求につき、1インスタンスのみを使用するように、DBコンテキスト、ユーザーマネージャー、サインインマネージャーを構成します。
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Users/Login")
            });
        }
    }
}