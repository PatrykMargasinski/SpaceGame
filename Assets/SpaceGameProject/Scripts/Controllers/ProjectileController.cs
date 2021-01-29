using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : Controller, ICollisional
{
    public GameObject owner;
    void Start()
    {
        movement=GetComponent<Movement>();
        collision=GetComponent<Collision>();
    }
    public Collision GetCollision()
    {
        return collision;
    }
    void OnDestroy()
    {
        bool success=SpaceGameManager.activeObjects.Remove(this);
    }
}
