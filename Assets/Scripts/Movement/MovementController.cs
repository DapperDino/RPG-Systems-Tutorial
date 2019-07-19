using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DapperDino.Movement
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(Animator))]
    public class MovementController : MonoBehaviour
    {
        [SerializeField] private float movementSpeed = 3f;
        [SerializeField] private float speedSmoothTime = 0.1f;

        private CharacterController controller = null;
        private Animator animator = null;
        private Transform mainCameraTransform = null;

        private float velocityY = 0f;
        private float speedSmoothVelocity = 0f;
        private float currentSpeed = 0f;

        private static readonly int hashSpeedPercentage = Animator.StringToHash("SpeedPercentage");

        private void Start()
        {
            controller = GetComponent<CharacterController>();
            animator = GetComponent<Animator>();
            mainCameraTransform = Camera.main.transform;
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            Vector2 movementInput = new Vector2(
                Input.GetAxisRaw("Horizontal"),
                Input.GetAxisRaw("Vertical")
            ).normalized;

            Vector3 forward = mainCameraTransform.forward;
            Vector3 right = mainCameraTransform.right;

            forward.y = 0f;
            right.y = 0f;

            forward.Normalize();
            right.Normalize();

            Vector3 desiredMoveDirection = (forward * movementInput.y + right * movementInput.x).normalized;

            if (desiredMoveDirection != Vector3.zero)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(desiredMoveDirection), 0.1f);
            }

            float targetSpeed = movementSpeed * movementInput.magnitude;
            currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedSmoothVelocity, speedSmoothTime);

            controller.Move(desiredMoveDirection * currentSpeed * Time.deltaTime);

            animator.SetFloat(hashSpeedPercentage, 0.5f * movementInput.magnitude, speedSmoothTime, Time.deltaTime);
        }
    }
}
