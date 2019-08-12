using DapperDino.Npcs.Occupations.Vendors;
using UnityEngine;

namespace DapperDino.Events.CustomEvents
{
    [CreateAssetMenu(fileName = "New Vendor Data Event", menuName = "Game Events/Vendor Data Event")]
    public class VendorDataEvent : BaseGameEvent<VendorData> { }
}
