using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sitecore.MediaFramework.Vimeo.Entities.Videos;

namespace Sitecore.MediaFramework.Vimeo.Entities
{
    public class Video : Asset
    {
        [JsonProperty("videoStillURL", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoStillUrl { get; set; }

        [JsonProperty("thumbnailURL", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailUrl { get; set; }

        public override string AssetId
        {
            get
            {
                if (!string.IsNullOrEmpty(Link))
                { return new Uri(this.Link).Segments.Last(); }
                return string.Empty;
            }
        }

        //[JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        //public string Uri { get; set; }

     

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

     

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int Duration { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int Width { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int Height { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public Stats Statistics { get; set; }


    }
}
