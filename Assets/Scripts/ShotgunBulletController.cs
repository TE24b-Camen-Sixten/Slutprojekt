using UnityEngine;
using UnityEngine.UIElements;

public class ShotgunBulletController : MonoBehaviour
{
    [SerializeField]
    float speed;
    void Start()
    {
        Destroy(gameObject, 5);
    }

    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
