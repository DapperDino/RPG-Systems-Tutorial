using System;
using DapperDino.Npcs;
using UnityEngine.Events;

namespace DapperDino.Events.UnityEvents
{
    [Serializable] public class UnityNpcEvent : UnityEvent<Npc> { }
}