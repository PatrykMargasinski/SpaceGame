using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : Collision
{
    public override void CollisionReaction()
    {
        Debug.Log("Projectile reaction");
    }
}
