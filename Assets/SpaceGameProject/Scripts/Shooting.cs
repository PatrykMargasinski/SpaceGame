﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour, IShooting
{
    public GameObject projectile;
    private Movement projMovement;
    void Start()
    {
        projMovement=projectile.GetComponent<Movement>();
    }
    public void Shoot()
    {
        projectile.transform.rotation=gameObject.transform.rotation;
        projMovement.moveX=10f*Mathf.Cos(gameObject.transform.rotation.eulerAngles.y*Mathf.Deg2Rad);
        projMovement.moveY=10f*-Mathf.Sin(gameObject.transform.rotation.eulerAngles.y*Mathf.Deg2Rad);
        var shootedProjectile=Instantiate(projectile,transform.position,transform.rotation);
        Destroy(shootedProjectile,2f);
    }
}
