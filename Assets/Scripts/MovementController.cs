using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    Vector2 moveInput;
    // Vector3 movement;

    [SerializeField]
    float jumpForce;
    [SerializeField]
    float gravityMultiplier;
    [SerializeField]
    int walkSpeed;
    [SerializeField]
    CharacterController controller;

    float velocityY = 0;

    void Update()
    {
        velocityY += Physics.gravity.y * (gravityMultiplier / 1000);
        if (controller.isGrounded && velocityY < 0)
        {
            velocityY = -1f;
        }

        Vector3 movement = moveInput.y * transform.forward + moveInput.x * transform.right;
        movement *= walkSpeed;

        movement.y = velocityY;

        controller.Move(movement * Time.deltaTime);
    }
    
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void OnJump(InputValue value)
    {
        if (controller.isGrounded)
        {
            velocityY = jumpForce;
        }
    }
}