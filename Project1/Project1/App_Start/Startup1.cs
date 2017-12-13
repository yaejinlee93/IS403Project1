/*using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Security.Google;
using Owin;

[assembly: OwinStartup(typeof(Project1.Startup))]

namespace Project1
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Configure the db context and user manager to use a single instance per request
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);

            // Enable the application to use a cookie to store information for the signed in user
            // and to use a cookie to temporarily store information about a user logging in with a third party login provider
            // Configure the sign in cookie
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString(“/ Account / Login”),
                Provider = new CookieAuthenticationProvider
                {
                    OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<ApplicationUserManager, ApplicationUser>(
                        validateInterval: TimeSpan.FromMinutes(30),
                        regenerateIdentity: (manager, user) => user.GenerateUserIdentityAsync(manager))
                }
            });

            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            {
                ClientId = "755099474087 - eio039ptqh2sp8jfsn0eh1vgpmli082n.apps.googleusercontent.com",
                ClientSecret = "3uNFNtfy9I - VOR0_RryIzuya"
           });
        }
    }
}*/