using TMPro;
using UnityEngine;

namespace DapperDino.Npcs.Occupations
{
    public class OccupationButton : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI occupationNameText = null;

        private IOccupation occupation = null;

        public void Initialise(IOccupation occupation) => this.occupation = occupation;

        public void TriggerOccupation() => occupation.Trigger();
    }
}
