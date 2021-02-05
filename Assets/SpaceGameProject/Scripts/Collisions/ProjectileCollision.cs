using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : Collision
{
    public override void CollisionReaction(Collision col)
    {
        Debug.Log("Projectile reaction "+col.GetType().ToString());
        if(col.gameObject!=GetComponent<Projectile>().owner)
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
