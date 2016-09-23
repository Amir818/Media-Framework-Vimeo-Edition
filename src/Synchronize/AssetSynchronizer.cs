using System.Globalization;

using StringUtil = Sitecore.Integration.Common.Utils.StringUtil;
using Sitecore.Data.Items;
using Sitecore.MediaFramework.Entities;
using Sitecore.MediaFramework.Export;
using Sitecore.MediaFramework.Vimeo.Entities;
using Sitecore.MediaFramework.Vimeo.Indexing.Entities;
using Sitecore.MediaFramework.Synchronize;


namespace Sitecore.MediaFramework.Vimeo.Synchronize
{
    public abstract class AssetSynchronizer : SynchronizerBase
    {
        public override Item SyncItem(object entity, Item accountItem)
        {
            var assetEntity = (Asset)entity;

            if (ExportQueueManager.IsExist(accountItem, FieldIDs.MediaElement.AssetId, assetEntity.AssetId))
            {
                return null;
            }

            return base.SyncItem(entity, accountItem);
        }

        public override Item GetRootItem(object entity, Item accountItem)
        {
            return accountItem.Children["Media Content"];
        }

        public override Item UpdateItem(object entity, Item accountItem, Item item)
        {
            var asset = (Asset)entity;
            using (new EditContext(item))
            {
                this.UpdateProperties(item, accountItem, asset);
            }

            return item;
        }

        public override bool NeedUpdate(object entity, Item accountItem, MediaServiceSearchResult searchResult)
        {
            var asset = (Asset)entity;
            var assetIndex = (AssetSearchResult)searchResult;

            return !Sitecore.Integration.Common.Utils.StringUtil
                .EqualsIgnoreNullEmpty(asset.ModifiedDate.ToString(), assetIndex.ModifiedDate.ToString());
        }

        public override MediaServiceSearchResult GetSearchResult(object entity, Item accountItem)
        {
            var asset = (Asset)entity;

            return base.GetSearchResult<VideoSearchResult>(Constants.IndexName, accountItem,
              i => (i.TemplateId == TemplateIDs.Video) && i.AssetId == asset.AssetId);
        }
        protected virtual void UpdateProperties(Item item, Item accountItem, Asset asset)
        {
            item.Name = ItemUtil.ProposeValidItemName(asset.Name);

            item[FieldIDs.MediaElement.AssetId] = asset.AssetId;
            item[FieldIDs.MediaElement.Name] = asset.Name;
            item[FieldIDs.MediaElement.Description] = asset.Description;
            item[FieldIDs.MediaElement.Link] = asset.Link;

            item[FieldIDs.MediaElement.CreationDate] = asset.CreationDate.ToString();
            item[FieldIDs.MediaElement.ModifiedDate] = asset.ModifiedDate.ToString();
        }

        public override MediaServiceEntityData GetMediaData(object entity)
        {
            var asset = (Asset)entity;

            return new MediaServiceEntityData { EntityId = asset.AssetId, EntityName = asset.Name };
        }
    }
}
