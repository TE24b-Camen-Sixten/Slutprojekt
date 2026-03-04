using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class LookAroundController : MonoBehaviour
{
    Vector2 input;
    float xRotation = 0f;
    [SerializeField]
    Vector2 sensitivity;
    [SerializeField]
    Camera head;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        xRotation += -input.y * sensitivity.y;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        head.transform.localEulerAngles = new(xRotation, 0, 0);

        transform.Rotate(Vector3.up, input.x * sensitivity.x);
    }
    void OnLook(InputValue value)
    {
        input = value.Get<Vector2>();
    }
    
}
