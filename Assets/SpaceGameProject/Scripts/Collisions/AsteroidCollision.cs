using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollision : Collision
{
    public override void CollisionReaction(Collision col)
    {
        Debug.Log("Asteroid reaction "+col.GetType().ToString());
    }
}
