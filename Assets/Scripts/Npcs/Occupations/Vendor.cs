using System.Collections.Generic;
using DapperDino.Items;
using UnityEngine;

namespace DapperDino.Npcs.Occupations
{
    public class Vendor : MonoBehaviour, IOccupation
    {
        public string Name => "Let's Trade!";

        private IItemContainer itemContainer = null;

        private void Start() => itemContainer = GetComponent<IItemContainer>();

        public void Trigger()
        {
            string itemNames = "";

            List<Item> items = itemContainer.GetAllItems();

            for (int i = 0; i < items.Count; i++)
            {
                itemNames += $"{items[i].name}, ";
            }

            Debug.Log(itemNames);
        }
    }
}
