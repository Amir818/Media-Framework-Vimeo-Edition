using Sitecore.Data;

namespace Sitecore.MediaFramework.Vimeo
{
    public static class Constants
    {
        public static readonly string SitecoreRestSharpService;
        public static readonly string IndexName;

        static Constants()
        {
            SitecoreRestSharpService = "mediaframework_vimeo";
            IndexName = "mediaframework_vimeo_index";
        }
    }

    public class TemplateIDs
    {
        public static ID Account;

        public static ID Video;

        public static ID Tag;

        public static ID Playlist;

        public static ID Player;

        static TemplateIDs()
        {
            TemplateIDs.Account = new ID("{DB13829B-6062-466F-9161-91B61A4F9820}");
            TemplateIDs.Video = new ID("{27831ED7-10E5-493A-8A1D-2DF633C705B2}");
            //TODO:

            TemplateIDs.Player = new ID("{B733A788-EB2E-4A43-9E08-93505E4E1AC1}");
        }

        public TemplateIDs()
        {
        }
    }
}
