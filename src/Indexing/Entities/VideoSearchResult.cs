using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sitecore.ContentSearch;
using Sitecore.MediaFramework.Entities;

namespace Sitecore.MediaFramework.Vimeo.Indexing.Entities
{
    public class VideoSearchResult : AssetSearchResult
    {
       [IndexField("duration")]
        public int Duration { get; set; }

        [IndexField("totalplays")]
        public int TotalPlays { get; set; }

        [IndexField("status")]
        public string Status { get; set; }
    }

}
