using System;
using DapperDino.Items;
using UnityEngine.Events;

namespace DapperDino.Events.UnityEvents
{
    [Serializable] public class UnityItemEvent : UnityEvent<Item> { }
}