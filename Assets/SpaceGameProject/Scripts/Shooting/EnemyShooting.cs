using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : Shooting
{
    public GameObject playerShip;
    public float shootingCooldown=1f;
    private float shootingTime=1f;
    public override bool ShootCondition()
    {
        shootingTime+=Time.deltaTime;
        if(shootingTime>1f)
        {
            shootingTime=0f;
            return Vector3.Distance(gameObject.transform.position,playerShip.transform.position)<20f;
        }
        return false;
    }
}
