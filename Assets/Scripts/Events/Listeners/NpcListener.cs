using DapperDino.Events.CustomEvents;
using DapperDino.Events.UnityEvents;
using DapperDino.Npcs;

namespace DapperDino.Events.Listeners
{
    public class NpcListener : BaseGameEventListener<Npc, NpcEvent, UnityNpcEvent> { }
}
