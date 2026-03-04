using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    Vector2 moveInput;
    Vector3 movement;

    [SerializeField]
    int walkSpeed;
    [SerializeField]
    CharacterController controller;

    void Update()
    {
        movement = moveInput.y * transform.forward + moveInput.x * transform.right;
        movement *= walkSpeed * Time.deltaTime;

        controller.Move(movement);
    }
    
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}