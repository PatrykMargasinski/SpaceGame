using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : SpaceObject
{
    public GameObject owner;
    void Start()
    {
        movement=GetComponent<Movement>();
        collision=GetComponent<Collision>();
    }
    void OnDestroy()
    {
        SpaceGameManager.collisionalObjects.Remove(this.collision);
    }
}
