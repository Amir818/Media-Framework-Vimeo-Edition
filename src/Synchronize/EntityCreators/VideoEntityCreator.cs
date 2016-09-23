using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data.Items;
using Sitecore.MediaFramework.Vimeo.Entities;
using Sitecore.MediaFramework.Vimeo.Entities.Videos;

namespace Sitecore.MediaFramework.Vimeo.Synchronize.EntityCreators
{
    public class VideoEntityCreator : AssetEntityCreator<Video>
    {
        public override object CreateEntity(Item item)
        {
        
            var video = (Video)base.CreateEntity(item);
           

            int totalPlays;
            int duration;

            Int32.TryParse(item[FieldIDs.Video.TotalPlays], out totalPlays);
            Int32.TryParse(item[FieldIDs.Video.Duration], out duration);

            var videoStats = new Stats();
            videoStats.Plays = totalPlays;
            video.Statistics = videoStats;
            video.Duration = duration;

            return video;
        }
    }
}
