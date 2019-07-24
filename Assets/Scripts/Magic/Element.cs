using UnityEngine;

namespace DapperDino.Magic
{
    [CreateAssetMenu(fileName = "New Element", menuName = "Magic/Element")]
    public class Element : ScriptableObject
    {
        [SerializeField] private new string name = "New Element Name";
        [SerializeField] private Color colour = new Color(1f, 1f, 1f, 1f);

        public string Name => name;
        public Color Colour => colour;
    }
}
