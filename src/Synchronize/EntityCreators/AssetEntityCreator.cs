using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data.Items;
using Sitecore.MediaFramework.Synchronize;
using Sitecore.MediaFramework.Vimeo.Entities;

namespace Sitecore.MediaFramework.Vimeo.Synchronize.EntityCreators
{
   public abstract class AssetEntityCreator<T> : IMediaServiceEntityCreator
        where T : Asset, new ()
    {
       public virtual object CreateEntity(Item item)
       {
            DateTime creationDate;
            DateTime lastModifiedDate;

            DateTime.TryParse(item[FieldIDs.MediaElement.CreationDate], out creationDate);
            DateTime.TryParse(item[FieldIDs.MediaElement.ModifiedDate], out lastModifiedDate);

           return new T
           {
               AssetId = item[FieldIDs.MediaElement.AssetId],
               Description = item[FieldIDs.MediaElement.Description],
               Name = item[FieldIDs.MediaElement.Name],
               CreationDate = creationDate,
               ModifiedDate = lastModifiedDate
               //ContentRating = item[FieldIDs.MediaElement.ContentRating]
           };
       }
    }
}
