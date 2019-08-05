using DapperDino.Events.CustomEvents;
using DapperDino.Interactables;
using DapperDino.Npcs.Occupations;
using UnityEngine;

namespace DapperDino.Npcs
{
    public class Npc : MonoBehaviour, IInteractable
    {
        [SerializeField] private NpcEvent onStartInteraction = null;
        [SerializeField] private new string name = "New Npc Name";
        [SerializeField] private string greetingText = "Hello adventurer!";

        private IOccupation[] occupations = new IOccupation[0];

        public string Name => name;
        public string GreetingText => greetingText;
        public IOccupation[] Occupations => occupations;

        private void Start() => occupations = GetComponents<IOccupation>();

        public void Interact(GameObject other) => onStartInteraction.Raise(this);
    }
}
