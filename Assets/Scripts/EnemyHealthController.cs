using UnityEngine;

public class EnemyHealthController : MonoBehaviour
{
    [SerializeField]
    int shotgunDMG;
    [SerializeField]
    int startHealth;
    int health;
    void Start()
    {
        health = startHealth;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "ShotgunShot")
        {
            TakeDamage(shotgunDMG);
        }
    }
    public void TakeDamage(int dmg)
    {
        health -= dmg;
        print(health);
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
