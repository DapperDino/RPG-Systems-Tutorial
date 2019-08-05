using DapperDino.Npcs;
using UnityEngine;

namespace DapperDino.Events.CustomEvents
{
    [CreateAssetMenu(fileName = "New Npc Event", menuName = "Game Events/Npc Event")]
    public class NpcEvent : BaseGameEvent<Npc> { }
}
