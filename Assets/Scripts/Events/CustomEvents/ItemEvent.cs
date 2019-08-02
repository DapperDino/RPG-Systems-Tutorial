using DapperDino.Items;
using UnityEngine;

namespace DapperDino.Events.CustomEvents
{
    [CreateAssetMenu(fileName = "New Item Event", menuName = "Game Events/Item Event")]
    public class ItemEvent : BaseGameEvent<Item> { }
}
