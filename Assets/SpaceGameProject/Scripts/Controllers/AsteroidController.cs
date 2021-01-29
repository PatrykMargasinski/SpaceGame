using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : Controller, ICollisional
{
    public float radius;

    void Start()
    {
        movement=GetComponent<Movement>();
        SpaceGameManager.activeObjects.Add(this);
    }

    public Vector3 GetPosition()
    {
        return transform.position;
    }
    public float GetRadius()
    {
        return radius;
    }
    public void CollisionReaction(Movement movement)
    {
        Debug.Log("Collision: "+gameObject.name);
        movement.SetNews(-movement.moveX,-movement.moveY);
    }
    public GameObject GetGameObject()
    {
        return gameObject;
    }
}
