using DapperDino.Items;
using DapperDino.Items.Inventories;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DapperDino.Npcs.Occupations.Vendors
{
    public class VendorSystem : MonoBehaviour
    {
        [SerializeField] private GameObject buttonPrefab = null;
        [SerializeField] private Transform buttonHolderTransform = null;
        [SerializeField] private GameObject selectedItemDataHolder = null;

        [Header("Data Display")]
        [SerializeField] private TextMeshProUGUI itemNameText = null;
        [SerializeField] private TextMeshProUGUI itemDescriptionText = null;
        [SerializeField] private TextMeshProUGUI itemDataText = null;

        [Header("Quantity Display")]
        [SerializeField] private TextMeshProUGUI quantityText = null;
        [SerializeField] private Slider quantitySlider = null;

        private VendorData scenarioData = null;
        private InventoryItem currentItem = null;

        public void StartScenario(VendorData scenarioData)
        {
            this.scenarioData = scenarioData;

            SetCurrentItemContainer(true);

            SetItem(scenarioData.SellingItemContainer.GetSlotByIndex(0).item);
        }

        public void SetCurrentItemContainer(bool isFirst)
        {
            ClearItemButtons();

            scenarioData.IsFirstContainerBuying = isFirst;

            var items = scenarioData.SellingItemContainer.GetAllUniqueItems();

            for (int i = 0; i < items.Count; i++)
            {
                GameObject buttonInstance = Instantiate(buttonPrefab, buttonHolderTransform);
                buttonInstance.GetComponent<VendorItemButton>().Initialise(
                    this,
                    items[i],
                    scenarioData.SellingItemContainer.GetTotalQuantity(items[i]));
            }

            selectedItemDataHolder.SetActive(false);
        }

        public void SetItem(InventoryItem item)
        {
            currentItem = item;

            if (item == null)
            {
                itemNameText.text = string.Empty;
                itemDescriptionText.text = string.Empty;
                itemDataText.text = string.Empty;
                return;
            }

            itemNameText.text = item.Name;
            itemDescriptionText.text = item.Description;
            itemDataText.text = item.GetInfoDisplayText();

            int totalQuantity = scenarioData.SellingItemContainer.GetTotalQuantity(item);
            quantityText.text = $"0/{totalQuantity}";
            quantitySlider.maxValue = totalQuantity;
            quantitySlider.value = 0;

            selectedItemDataHolder.SetActive(true);
        }

        public void UpdateSliderText(float quantity)
        {
            int totalQuantity = scenarioData.SellingItemContainer.GetTotalQuantity(currentItem);
            quantityText.text = $"{quantity}/{totalQuantity}";
        }

        public void ConfirmButton()
        {
            int price = currentItem.SellPrice * (int)quantitySlider.value;

            if (scenarioData.BuyingItemContainer.Money < price) { return; }

            scenarioData.BuyingItemContainer.Money -= price;
            scenarioData.SellingItemContainer.Money += price;

            var itemSlotSawp = new ItemSlot(currentItem, (int)quantitySlider.value);

            bool soldAll = (int)quantitySlider.value == scenarioData.SellingItemContainer.GetTotalQuantity(currentItem);

            if (soldAll) { selectedItemDataHolder.SetActive(false); }

            scenarioData.BuyingItemContainer.AddItem(itemSlotSawp);
            scenarioData.SellingItemContainer.RemoveItem(itemSlotSawp);

            SetCurrentItemContainer(scenarioData.IsFirstContainerBuying);

            if (!soldAll) { SetItem(currentItem); }
        }

        private void ClearItemButtons()
        {
            foreach (Transform child in buttonHolderTransform)
            {
                Destroy(child.gameObject);
            }
        }
    }
}

