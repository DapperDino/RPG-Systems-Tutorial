using UnityEngine;

namespace DapperDino.Interactables
{
    public class TestInteractable : MonoBehaviour, IInteractable
    {
        [SerializeField] private string interactionText = "Hello";

        public void Interact() => Debug.Log(interactionText);
    }
}
