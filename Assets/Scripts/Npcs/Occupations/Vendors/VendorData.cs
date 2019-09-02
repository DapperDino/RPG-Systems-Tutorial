using DapperDino.Items;

namespace DapperDino.Npcs.Occupations.Vendors
{
    public class VendorData
    {
        public VendorData(
            IItemContainer buyingItemContainer,
            IItemContainer sellingItemContainer)
        {
            itemContainers[0] = buyingItemContainer;
            itemContainers[1] = sellingItemContainer;
        }

        private IItemContainer[] itemContainers = new IItemContainer[2];
        public bool IsFirstContainerBuying { get; set; } = true;

        public IItemContainer BuyingItemContainer => IsFirstContainerBuying ? itemContainers[0] : itemContainers[1];
        public IItemContainer SellingItemContainer => IsFirstContainerBuying ? itemContainers[1] : itemContainers[0];
    }
}
