using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAL.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            //Install-Package Microsoft.IdentityModel.Clients.ActiveDirectory -Version 2.29.0
            //using Microsoft.IdentityModel.Clients.ActiveDirectory;

            Run();
        }

        public static void Run()
        {
            string authorityUri = "https://login.windows.net/common/oauth2/authorize";

            //OU

            //string authorityUri = "https://login.microsoftonline.com/88c6ab5a-c061-429b-8379-3fc56d15fe40/oauth2/authorize"; // Portal Azure - Azure AD - App - OAuth 2.0 token endpoint

            AuthenticationContext authContext = new AuthenticationContext(authorityUri);

            string resource = "https://labetcrm.onmicrosoft.com/1644a3f5-1fa9-4a14-8d88-ea472ffc9668"; // Portal Azure - Azure AD - App - Properties - App ID URI
            string clientId = "c197d3df-3557-498e-bda1-7b653bc5e362"; // Portal Azure - Azure AD - App - App Properties - Application ID
            string secret = "bi0jYwI4IAuQAYHlecDLxB/BE/SM/NagwqfLA5z1nj8="; // Portal Azure - Azure AD - App - Keys - Secret

            ClientCredential credential = new ClientCredential(clientId, secret);

            var result = authContext.AcquireToken(resource, credential);

            var accessToken = result.AccessToken;
            var authHeader = result.CreateAuthorizationHeader();
        }
    }
}
