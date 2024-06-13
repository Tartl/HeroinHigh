using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCShoot : MonoBehaviour
{
    public GameObject had;
    public Transform firePoint;
    public void Shoot()
    {
        Instantiate(had,firePoint.position,Quaternion.identity);
    }
}
