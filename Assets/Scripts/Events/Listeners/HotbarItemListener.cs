using DapperDino.Events.CustomEvents;
using DapperDino.Events.UnityEvents;
using DapperDino.Items.Hotbars;

namespace DapperDino.Events.Listeners
{
    public class ItemListener : BaseGameEventListener<Item, ItemEvent, UnityItemEvent> { }
}
