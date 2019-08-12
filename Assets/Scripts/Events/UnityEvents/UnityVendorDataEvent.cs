using System;
using DapperDino.Npcs.Occupations.Vendors;
using UnityEngine.Events;

namespace DapperDino.Events.UnityEvents
{
    [Serializable] public class UnityVendorDataEvent : UnityEvent<VendorData> { }
}