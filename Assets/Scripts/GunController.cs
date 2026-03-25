using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField]
    int dmg;

    public void Shoot(Vector3 targetPos)
    {
        RaycastHit Hit;
        EnemyHealthController Enemy;
        Vector3 Direction = (targetPos - transform.position).normalized;

        if (Physics.Raycast(transform.position, Direction, out Hit, 50))
        {
            Hit.transform.TryGetComponent(out Enemy);
            Enemy.TakeDamage(dmg);
        }
    }
}
