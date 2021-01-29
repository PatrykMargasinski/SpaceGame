using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollision : Collision
{
    public override void CollisionReaction()
    {
        Debug.Log("Asteroid reaction");
    }
}
