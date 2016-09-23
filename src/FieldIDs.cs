using Sitecore.Data;

namespace Sitecore.MediaFramework.Vimeo
{
    public static class FieldIDs
    {

        public static class Account
        {
            public static readonly ID Token = new ID("{B2012E79-8B43-4660-8815-B0376074A40A}");

            public static readonly ID ApplicationId = new ID("{E7EB9EE7-E5E4-4F99-9B91-7C88B0093137}");

        }
        public static class MediaElement
        {
            public static readonly ID AssetId = new ID("{506CF65D-3A17-4430-83E8-A81739A4E581}");

            public static readonly ID Name = new ID("{941D41B8-5316-4DD3-A965-A25B9810F17A}");

            public static readonly ID Description = new ID("{09AA3F0A-640F-4D81-A728-D215E7879FC8}");

            public static readonly ID Link = new ID("{B245610C-428B-4C26-BE44-9ACB002C3B1C}");

            public static readonly ID CreationDate = new ID("{E04EA5AB-BD13-4608-8C8A-C0706F5802FA}");
            public static readonly ID ModifiedDate = new ID("{8CDE4893-BB35-477F-AE0F-5D2F3573D14B}");
            public static readonly ID ContentRating = new ID("{94497120-B933-430D-98E1-55A3C2642AEC}");

            public static readonly ID PreviewImageUrl = new ID("{43C27714-FC71-4678-A41F-C4FA28C7CAF1}");
        }

        public static class Video
        {
            public static readonly ID Status = new ID("{D43AF76E-5069-466E-ACB1-B85683BBCF21}");

            public static readonly ID Duration = new ID("{6EBD4B1E-2D40-484E-93C8-E8E399103148}");

            public static readonly ID TotalPlays = new ID("{FFED8FAE-E701-4E1D-8DDA-E56837CA7E4B}");


        }
    }





}
