using UnityEngine;

public class PickUpReciever : MonoBehaviour
{
    [SerializeField]
    Camera player;
    public void PickUp()
    {
        RaycastHit answer;
        Vector3 direction = (player.transform.position - transform.position).normalized;
        if(Physics.Raycast(transform.position, direction, out answer, 10))
        {
            answer.transform.SendMessage("SetGunActive");  
        }

        this.gameObject.SetActive(false);
    }
}
