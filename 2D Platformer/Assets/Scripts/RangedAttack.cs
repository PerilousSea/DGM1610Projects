using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAttack : MonoBehaviour
{
    public Transform firePoint;
    public GameObject fungiMold;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    //FirePoint is the Empty GameObject at which the projectile(fungiMold) leaves from
    void Shoot()
    {
        Instantiate(fungiMold, firePoint.position, firePoint.rotation);
    } 

}
