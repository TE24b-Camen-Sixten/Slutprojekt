using UnityEngine;
using UnityEngine.UIElements;

public class ShootController : MonoBehaviour
{
    int alternator = 1;
    void OnClick()
    {
        alternator += 1;
        if (alternator % 2 == 0) // ser till att det bara skjuter när man klickar ner, inte släpper upp knappen.
        {
            RaycastHit target;
            if(Physics.Raycast(transform.position, transform.forward, out target, 50))
            {
                Vector3 targetPos = target.transform.position;
                GetComponentInChildren<GunController>().Shoot(targetPos);
            } 
        }
    }
}
