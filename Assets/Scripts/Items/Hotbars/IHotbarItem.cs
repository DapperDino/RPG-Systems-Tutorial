using UnityEngine;

namespace DapperDino.Items.Hotbars
{
    public interface IHotbarItem
    {
        string Name { get; }
        Sprite Icon { get; }
        void Use();
    }
}

