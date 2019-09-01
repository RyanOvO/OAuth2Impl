using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System.Collections.Generic;
using System.IdentityModel.Tokens;

namespace oAuthOidcOwinClient
{
    public class Startup
    {
        /// <summary>
        /// OWin实现  Identity
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {

            JwtSecurityTokenHandler.InboundClaimTypeMap = new Dictionary<string, string>();

            //This is just used securing this application.  
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "Cookie",
                AuthenticationMode = AuthenticationMode.Active
            });

            //This is just used to store State and (maybe) Nonce values
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "TempCookie",
                AuthenticationMode = AuthenticationMode.Passive
            });

        }
    }
}