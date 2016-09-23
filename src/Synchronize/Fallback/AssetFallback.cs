using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.MediaFramework.Entities;
using Sitecore.MediaFramework.Synchronize.Fallback;
using Sitecore.MediaFramework.Vimeo.Indexing.Entities;

namespace Sitecore.MediaFramework.Vimeo.Synchronize.Fallback
{
    public abstract class AssetFallback<T> : DatabaseFallbackBase
         where T : AssetSearchResult, new()
    {
        protected override MediaServiceSearchResult GetSearchResult(Item item)
        {
            DateTime creationDate;
            DateTime lastModifiedDate;

            DateTime.TryParse(item[FieldIDs.MediaElement.CreationDate], out creationDate);
            DateTime.TryParse(item[FieldIDs.MediaElement.ModifiedDate], out lastModifiedDate);

            return new T
            {
                AssetId = item[FieldIDs.MediaElement.AssetId],
                AssetName = item[FieldIDs.MediaElement.Name],
                Description = item[FieldIDs.MediaElement.Description],
                CreationDate = creationDate,
                ModifiedDate = lastModifiedDate,
                PreviewImageUrl = item[FieldIDs.MediaElement.PreviewImageUrl]
            };
        }
    }
}
