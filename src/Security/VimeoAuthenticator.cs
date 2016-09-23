using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Sitecore.Data.Items;

namespace Sitecore.MediaFramework.Vimeo.Security
{
    public class VimeoAuthenticator : IAuthenticator
    {
        public readonly string ClientId;
        public readonly string ClientSecret;
        public readonly string Token;
        public readonly string AppId;
        public VimeoAuthenticator(Item accountItem)
        {
            this.Token = accountItem[FieldIDs.Account.Token];
            this.AppId = accountItem[FieldIDs.Account.ApplicationId];
        }
        public void Authenticate(IRestClient client, IRestRequest request)
        {
            request.AddUrlSegment("token", this.Token);
        }

        public IAuthenticator GetAuthenticator()
        {
            return string.IsNullOrEmpty(this.Token) ? new OAuth2AuthorizationRequestHeaderAuthenticator(this.Token, "Bearer") : null;
        }
    }
}
