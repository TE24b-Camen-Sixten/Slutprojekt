using UnityEngine;
using Random = UnityEngine.Random;

public class ShotgunController : MonoBehaviour
{
    [SerializeField]
    GameObject skott;
    [SerializeField]
    float spread;

    public void Shoot(Vector3 targetPos)
    {

        if(targetPos == new Vector3(0, 0, 0))
        {
            for (int i = 0; i < 10; i++)
            {
                float randomX = Random.Range(-spread, spread);
                float randomY = Random.Range(-spread, spread);
                float randomZ = Random.Range(-spread, spread);
                Instantiate(skott, transform.position, transform.rotation * Quaternion.Euler(270, 0, 0) * Quaternion.Euler(randomX, randomY, randomZ));
            }
        }
        else
        {
            Vector3 direction = (targetPos - transform.position).normalized;
            for (int i = 0; i < 10; i++)
            {
                float randomX = Random.Range(-spread, spread);
                float randomY = Random.Range(-spread, spread);
                float randomZ = Random.Range(-spread, spread);
                Instantiate(skott, transform.position, Quaternion.LookRotation(direction) * Quaternion.Euler(randomX, randomY, randomZ));   
            }
        }
    }
}
