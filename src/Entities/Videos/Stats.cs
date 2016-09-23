using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sitecore.MediaFramework.Vimeo.Entities.Videos
{
    public class Stats
    {
        [JsonProperty("plays", NullValueHandling = NullValueHandling.Ignore)]
        public int Plays { get; set; }

        [JsonProperty("likes", NullValueHandling = NullValueHandling.Ignore)]
        public int Likes { get; set; }

        [JsonProperty("comments", NullValueHandling = NullValueHandling.Ignore)]
        public int Comments { get; set; }
    }
}
