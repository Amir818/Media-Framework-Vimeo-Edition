using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.MediaFramework.Vimeo.Entities;

namespace Sitecore.MediaFramework.Vimeo.Import
{
    public class VideoCollectionImporter : EntityCollectionImporter<Video>
    {
        protected override string RequestName
        {
            get { return "read_videos"; }
        }
    }
}
