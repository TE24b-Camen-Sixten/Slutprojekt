using UnityEngine;

public class ShotgunController : MonoBehaviour
{
    [SerializeField]
    GameObject skott;
    public void Shoot(Vector3 targetPos)
    {
        Vector3 direction = (targetPos - transform.position).normalized;
        Instantiate(skott, transform.position, Quaternion.LookRotation(direction));
    }
}
