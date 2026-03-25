using UnityEngine;
using UnityEngine.InputSystem;

public class InvntoryManager : MonoBehaviour
{   
    [SerializeField]
    GameObject gun;
    [SerializeField]
    GameObject shotgun;
    
    public bool haveGun = false;
    public bool haveShotgun = false;

    public void pickedUpGun()
    {
        if (haveGun && haveShotgun)
        {
            gun.SetActive(false);
            shotgun.SetActive(true);
        }
    }

    void OnPress1()
    {
        shotgun.SetActive(true);
        gun.SetActive(false);
    }
    void OnPress2()
    {
        shotgun.SetActive(false);
        gun.SetActive(true);
    }
}
