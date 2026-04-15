using UnityEngine;

public class ShotgunController : MonoBehaviour
{
    [SerializeField]
    GameObject skott;
    public void Shoot()
    {
        print("po e bog");
        Instantiate(skott, transform.position, transform.rotation);
    }
}
