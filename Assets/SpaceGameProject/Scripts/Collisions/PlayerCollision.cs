using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : Collision
{
    public override void CollisionReaction()
    {
        Debug.Log("Player reaction");
        Movement mov=GetComponent<Movement>();
        mov.SetNews(-mov.moveX,-mov.moveY);
    }
}
