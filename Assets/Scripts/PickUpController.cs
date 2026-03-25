using UnityEngine;

public class PickUpController : MonoBehaviour
{
    [SerializeField]
    Camera camera;
    [SerializeField]
    GameObject gun;
    [SerializeField]
    GameObject shotgun;

    InvntoryManager inventory;

    void Start()
    {
        gun.SetActive(false);
        shotgun.SetActive(false);
    }
    void OnInteract()
    {
        RaycastHit pickUp;

        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out pickUp, 5))
        {
            pickUp.transform.SendMessage("PickUp");
        }
    }

    public void SetGunActive(string name)
    {
        inventory = GetComponentInParent<InvntoryManager>();

        print(name + "recived");
        if(name == "gun")
        {
            gun.SetActive(true);
            inventory.haveGun = true;
        }
        else if (name == "shotgun")
        {
            shotgun.SetActive(true);
            inventory.haveShotgun = true;
        }
        inventory.pickedUpGun();
    }
}
