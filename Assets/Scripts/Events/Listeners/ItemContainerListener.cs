using DapperDino.Events.CustomEvents;
using DapperDino.Events.UnityEvents;
using DapperDino.Items;

namespace DapperDino.Events.Listeners
{
    public class ItemContainerListener : BaseGameEventListener<IItemContainer, ItemContainerEvent, UnityItemContainerEvent> { }
}
