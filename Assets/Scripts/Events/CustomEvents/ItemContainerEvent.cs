using DapperDino.Items;
using UnityEngine;

namespace DapperDino.Events.CustomEvents
{
    [CreateAssetMenu(fileName = "New Item Container Event", menuName = "Game Events/Item Container Event")]
    public class ItemContainerEvent : BaseGameEvent<IItemContainer> { }
}
