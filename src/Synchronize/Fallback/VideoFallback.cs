using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data.Items;
using Sitecore.MediaFramework.Entities;
using Sitecore.MediaFramework.Vimeo.Entities;
using Sitecore.MediaFramework.Vimeo.Indexing.Entities;

namespace Sitecore.MediaFramework.Vimeo.Synchronize.Fallback
{
    public class VideoFallback : AssetFallback<VideoSearchResult>
    {
        protected override Item GetItem(object entity,Item accountItem)
        {
            Video video = (Video)entity;
            return accountItem.Axes.SelectSingleItem(string.Format("./Media Content//*[@@templateid='{0}' and @assetid='{1}']", TemplateIDs.Video, video.AssetId));
        }

        protected override MediaServiceSearchResult GetSearchResult(Item item)
        {
            VideoSearchResult videoSearchResult = (VideoSearchResult)base.GetSearchResult(item);

            int totalPlays;
            int duration;

            Int32.TryParse(item[FieldIDs.Video.TotalPlays], out totalPlays);
            Int32.TryParse(item[FieldIDs.Video.Duration], out duration);

            videoSearchResult.TotalPlays = totalPlays;
            videoSearchResult.Duration = duration;
            videoSearchResult.Status = item[FieldIDs.Video.Status];

            return videoSearchResult;
        }
    }
}
