using UnityEngine;

namespace DapperDino.Interactables
{
    public class Interactor : MonoBehaviour
    {
        private IInteractable currentInteractable = null;

        private void Update()
        {
            CheckForInteraction();
        }

        private void CheckForInteraction()
        {
            if (currentInteractable == null) { return; }

            if (Input.GetKeyDown(KeyCode.E))
            {
                currentInteractable.Interact();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            var interactable = other.GetComponent<IInteractable>();

            if (interactable == null) { return; }

            currentInteractable = interactable;
        }

        private void OnTriggerExit(Collider other)
        {
            var interactable = other.GetComponent<IInteractable>();

            if (interactable == null) { return; }

            if (interactable != currentInteractable) { return; }

            currentInteractable = null;
        }
    }
}
