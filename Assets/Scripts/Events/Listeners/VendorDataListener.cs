using DapperDino.Events.CustomEvents;
using DapperDino.Events.UnityEvents;
using DapperDino.Npcs.Occupations.Vendors;

namespace DapperDino.Events.Listeners
{
    public class VendorDataListener : BaseGameEventListener<VendorData, VendorDataEvent, UnityVendorDataEvent> { }
}
