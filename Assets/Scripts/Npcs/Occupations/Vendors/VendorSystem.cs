using UnityEngine;

namespace DapperDino.Npcs.Occupations.Vendors
{
    public class VendorSystem : MonoBehaviour
    {
        [SerializeField] private GameObject buttonPrefab = null;
        [SerializeField] private Transform buttonHolderTransform = null;

        public void StartScenario(VendorData scenarioData)
        {
            var items = scenarioData.SellingItemContainer.GetAllItems();

            for (int i = 0; i < items.Count; i++)
            {
                GameObject buttonInstance = Instantiate(buttonPrefab, buttonHolderTransform);
                buttonInstance.GetComponent<VendorItemButton>().Initialise(
                    items[i],
                    scenarioData.SellingItemContainer.GetTotalQuantity(items[i]));
            }
        }
    }
}

