using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : Collision
{
    public override void CollisionReaction(Collision col)
    {
        Debug.Log("Player reaction "+col.GetType().ToString());
        if("ProjectileCollision"!=col.GetType().ToString())
        {
            Movement mov=GetComponent<Movement>();
            mov.SetNewVelocityVector(-mov.speedX,-mov.speedY);
        }
    }
}
