using DapperDino.Items;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DapperDino.Npcs.Occupations.Vendors
{
    public class VendorItemButton : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI itemNameText = null;
        [SerializeField] private Image itemIconImage = null;

        public void Initialise(Item item, int quantity)
        {
            itemNameText.text = $"{item.Name} ({quantity})";
            itemIconImage.sprite = item.Icon;
        }
    }
}