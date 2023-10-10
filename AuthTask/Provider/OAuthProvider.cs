using AuthTask.Models;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace AuthTask.Provider
{

    public class OAuthProvider : OAuthAuthorizationServerProvider
    {
        public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext X)
        {
            return Task.Factory.StartNew(() =>
            {
                var username = X.UserName;
                var password = X.Password;
                Demo user = DAL.ValidateUser(username, password);
                if (user != null)
                {
                    var claims = new List<Claim>()
                    {
                        
                        new Claim("PK_LoginID", user.PK_LoginID)
                    };
                    ClaimsIdentity oAutIdentity = new ClaimsIdentity(claims, Startup.OAuthOptions.AuthenticationType);
                    X.Validated(new AuthenticationTicket(oAutIdentity, new AuthenticationProperties() { }));
                }
                else
                {
                    X.SetError("invalid_grant", "Error");
                }
            });
        }

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            if (context.ClientId == null)
            {
                context.Validated();
            }
            return Task.FromResult<object>(null);
        }
    }
    }
    

    
