using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sitecore.MediaFramework.Vimeo.Entities.Collections
{
    public class PagedCollection<T>
    {
        [JsonProperty("total")]
        public int TotalCount { get; set; }
 
        [JsonProperty("per_page")]
        public int PageSize { get; set; }

        [JsonProperty("page")]
        public int PageNumber { get; set; }
        
        [JsonProperty("data")]
        public List<T> Items { get; set; }


    }
}
