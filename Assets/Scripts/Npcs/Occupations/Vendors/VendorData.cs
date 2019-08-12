using DapperDino.Items;

namespace DapperDino.Npcs.Occupations.Vendors
{
    public class VendorData
    {
        public VendorData(
            IItemContainer buyingItemContainer,
            IItemContainer sellingItemContainer)
        {
            BuyingItemContainer = buyingItemContainer;
            SellingItemContainer = sellingItemContainer;
        }

        public IItemContainer BuyingItemContainer { get; } = null;
        public IItemContainer SellingItemContainer { get; } = null;
    }
}
