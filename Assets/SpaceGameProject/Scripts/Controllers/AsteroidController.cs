using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : Controller, ICollisional
{
    void Start()
    {
        movement=GetComponent<Movement>();
        collision=GetComponent<Collision>();
    }

    public Collision GetCollision()
    {
        return collision;
    }
}
