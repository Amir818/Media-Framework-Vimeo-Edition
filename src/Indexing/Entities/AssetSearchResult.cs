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
    public class AssetSearchResult : MediaServiceSearchResult
    {
        [IndexField("assetid")]
        public virtual string AssetId { get; set; }

        [IndexField("name")]
        public string AssetName { get; set; }

        [IndexField("link")]
        public string Link { get; set; }

        [IndexField("description")]
        public string Description { get; set; }

        [IndexField("creationdate")]
        public DateTime? CreationDate { get; set; }

        [IndexField("modifieddate")]
        public DateTime? ModifiedDate { get; set; }

        [IndexField("previewimageurl")]
        public string PreviewImageUrl { get; set; }

    }

}
