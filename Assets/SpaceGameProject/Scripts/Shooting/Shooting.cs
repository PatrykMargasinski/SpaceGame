using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shooting : MonoBehaviour
{
    public GameObject projectile;
    private Movement projMovement;
    private Projectile projectileSpaceObject;
    public abstract bool ShootCondition();
    void Start()
    {
        projMovement=projectile.GetComponent<Movement>();
        projectileSpaceObject=projectile.GetComponent<Projectile>();
        projectileSpaceObject.owner=gameObject;
    }
    public void Shoot()
    {
        projectile.transform.rotation=gameObject.transform.rotation;
        projMovement.speedX=10f*Mathf.Cos(gameObject.transform.rotation.eulerAngles.y*Mathf.Deg2Rad);
        projMovement.speedY=10f*-Mathf.Sin(gameObject.transform.rotation.eulerAngles.y*Mathf.Deg2Rad);
        var shootedProjectile=Instantiate(projectile,transform.position,transform.rotation);
        shootedProjectile.GetComponent<Projectile>().owner=gameObject;
        Destroy(shootedProjectile,2f);
    }
    void Update()
    {
        if(ShootCondition())Shoot();
    }
}
