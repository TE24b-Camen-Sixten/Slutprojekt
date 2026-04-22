using System;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    int alternator = 1;
    void OnClick()
    {
        alternator += 1;
        if (alternator % 2 == 0) // ser till att det bara skjuter när man klickar ner, inte släpper upp knappen.
        {
            RaycastHit target;
            if (Physics.Raycast(transform.position, transform.forward, out target, 50))
            {
                Vector3 targetPos = target.point;
                try
                {
                    GetComponentInChildren<GunController>().Shoot(targetPos);
                }
                catch(NullReferenceException) { }
                try
                {
                    GetComponentInChildren<ShotgunController>().Shoot(targetPos);
                }
                catch(NullReferenceException) { }
            }
            else
            {
                Vector3 noDir = new Vector3(0,0,0);
                
                try
                {
                    GetComponentInChildren<ShotgunController>().Shoot(noDir);
                }
                catch(NullReferenceException) { }
            }

        }
    }
}
