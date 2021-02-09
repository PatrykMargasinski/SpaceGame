using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : SpaceObject
{
    public GameObject owner;
    void Start()
    {
        
    }
    void OnDestroy()
    {
        //SpaceGameManager.collisionalObjects.Remove(this.collision);
    }
}
