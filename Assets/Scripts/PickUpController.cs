using Unity.VisualScripting;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    [SerializeField]
    Camera camera;
    [SerializeField]
    GameObject gun;

    void Start()
    {
        gun.SetActive(false);
    }
    void OnInteract()
    {
        RaycastHit pickUp;

        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out pickUp, 5))
        {
            pickUp.transform.SendMessage("PickUp");
        }
    }

    public void SetGunActive()
    {
        gun.SetActive(true);
    }
}
