﻿using DapperDino.Events.CustomEvents;
using DapperDino.Events.UnityEvents;

namespace DapperDino.Events.Listeners
{
    public class IntListener : BaseGameEventListener<int, IntEvent, UnityIntEvent> { }
}
