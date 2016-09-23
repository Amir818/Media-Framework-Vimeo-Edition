using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sitecore.MediaFramework.Vimeo.Entities
{
    public abstract class Asset
    {
        [JsonProperty("assetId", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string AssetId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreationDate { get; set; }

        [JsonProperty("modified_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ModifiedDate { get; set; }

        [JsonProperty("release_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ReleaseDate { get; set; }

        public override string ToString()
        {
            return string.Format("(type:{0},id:{1},name:{2})", this.GetType().Name, this.AssetId, this.Name);
        }
    }
}
