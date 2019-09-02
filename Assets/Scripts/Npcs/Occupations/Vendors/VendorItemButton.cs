using DapperDino.Items.Inventories;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DapperDino.Npcs.Occupations.Vendors
{
    public class VendorItemButton : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI itemNameText = null;
        [SerializeField] private Image itemIconImage = null;

        private VendorSystem vendorSystem = null;
        private InventoryItem item = null;

        public void Initialise(VendorSystem vendorSystem, InventoryItem item, int quantity)
        {
            this.vendorSystem = vendorSystem;
            this.item = item;

            itemNameText.text = $"{item.Name} ({quantity})";
            itemIconImage.sprite = item.Icon;
        }

        public void SelectItem()
        {
            vendorSystem.SetItem(item);
        }
    }
}