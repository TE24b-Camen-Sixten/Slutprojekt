using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class PickUpReciever : MonoBehaviour
{
    [SerializeField]
    Camera player;
    public void PickUp()
    {

        RaycastHit answer;
        PickUpController controller;

        Vector3 direction = (player.transform.position - transform.position).normalized;
        if (Physics.Raycast(transform.position, direction, out answer, 10))
        {
            answer.transform.TryGetComponent<PickUpController>(out controller);
            if (gameObject.name == "GunPickUp")
            {
                print("sendback gun");  
                controller.SetGunActive("gun");
            }
            else if (gameObject.name == "ShotgunPickUp")
            {
                print("sendback shotgun");  
                controller.SetGunActive("shotgun");
            }
            
            gameObject.SetActive(false);
        }

    }
}
