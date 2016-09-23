using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using RestSharp;
using Sitecore.MediaFramework.Diagnostics;
using Sitecore.MediaFramework.Import;
using Sitecore.MediaFramework.Vimeo.Entities.Collections;
using Sitecore.RestSharp;

namespace Sitecore.MediaFramework.Vimeo.Import
{
    public abstract class EntityCollectionImporter<TEntity> : IImportExecuter
    {
        protected abstract string RequestName { get; }
        public IEnumerable<object> GetData(Sitecore.Data.Items.Item accountItem)
        {
            var authenticator = new Security.VimeoAuthenticator(accountItem).GetAuthenticator(); 
            return authenticator != null ? this.GetWithPaging(authenticator) : null;
        }

        protected virtual IEnumerable<object> GetWithPaging(IAuthenticator authenticator)
        {
            var context = new RestContext(Constants.SitecoreRestSharpService, authenticator);
            var parameters = new List<Parameter>();

            var pageNumber = new Parameter { Type = ParameterType.UrlSegment, Name = "page", Value = -1 };

            parameters.Add(pageNumber);

            int totalCount;
            int count = 0;

            do
            {
                pageNumber.Value = (int)pageNumber.Value + 1;
                var data = context.Read<PagedCollection<TEntity>>(this.RequestName, parameters);

                if (data == null || data.Data == null || data.Data.Items == null)
                {
                    LogHelper.Warn("Null Result during importing", this);
                    throw new HttpException("Http null result");
                }
                totalCount = data.Data.TotalCount;

                if (data.Data.Items.Count == 0)
                {
                    yield break;
                }

                foreach (TEntity entity in data.Data.Items)
                {
                    yield return entity;
                }

                count += data.Data.Items.Count;

            }
            while (count < totalCount);
        }
    }
}
