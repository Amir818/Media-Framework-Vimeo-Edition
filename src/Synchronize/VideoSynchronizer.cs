using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data.Items;
using Sitecore.MediaFramework.Entities;
using Sitecore.MediaFramework.Vimeo.Entities;

namespace Sitecore.MediaFramework.Vimeo.Synchronize
{
    public class VideoSynchronizer : AssetSynchronizer
    {
        protected override void UpdateProperties(Item item, Item accountItem, Asset asset)
        {
            base.UpdateProperties(item, accountItem, asset);

            var video = (Video) asset;

            item[FieldIDs.Video.Duration] = video.Duration.ToString();
            item[FieldIDs.Video.Status] = video.Status;
            item[FieldIDs.Video.TotalPlays] = video.Statistics != null ? video.Statistics.Plays.ToString() : "0";
        }

        public override MediaServiceEntityData GetMediaData(object entity)
        {
            var mediaData = base.GetMediaData(entity);

            mediaData.TemplateId = TemplateIDs.Video;

            return mediaData;
        }
    }
}
