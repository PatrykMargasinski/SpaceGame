using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : SpaceObject
{
    void Start()
    {
        movement=GetComponent<Movement>();
        collision=GetComponent<Collision>();
    }

    void OnDestroy()
    {
        //Instantiate(explosion,transform.position,Quaternion.identity);
    }
}
