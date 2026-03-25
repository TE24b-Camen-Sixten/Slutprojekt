using UnityEngine;

public class EnemyHealthController : MonoBehaviour
{
    [SerializeField]
    int startHealth;
    int health;
    void Start()
    {
        health = startHealth;
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
