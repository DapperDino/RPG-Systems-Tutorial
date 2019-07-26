using UnityEngine;

namespace DapperDino.Items.Inventories
{
    public class InventoryBehaviour : MonoBehaviour, IItemContainer
    {
        [SerializeField] private Inventory inventory = null;

        private void Start()
        {
            inventory.SetSize(20);
        }

        public ItemSlot AddItem(ItemSlot itemSlot) => inventory.AddItem(itemSlot);
        public int GetTotalQuantity(InventoryItem item) => inventory.GetTotalQuantity(item);
        public bool HasItem(InventoryItem item) => inventory.HasItem(item);
        public void RemoveAt(int slotIndex) => inventory.RemoveAt(slotIndex);
        public void RemoveItem(ItemSlot itemSlot) => inventory.RemoveItem(itemSlot);
        public void Swap(int indexOne, int indexTwo) => inventory.Swap(indexOne, indexTwo);
    }
}