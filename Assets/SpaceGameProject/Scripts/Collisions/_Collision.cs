using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collision : MonoBehaviour
{
    public float radius;
    public abstract void CollisionReaction();
    public Vector3 GetPosition()
    {
        return gameObject.transform.position;
    }
    public float GetRadius()
    {
        return radius;
    }
    public void CheckCollision()
    {
        foreach(ICollisional col in SpaceGameManager.activeObjects)
        {
            bool isCollisionDistance=Vector3.Distance(GetPosition(), col.GetCollision().GetPosition()) <= GetRadius() + col.GetCollision().GetRadius();
            bool notSelfCollision=this.gameObject!=col.GetCollision().gameObject;
            if(isCollisionDistance && notSelfCollision)
            {
                CollisionReaction();
                return;
            }
        }
    }
    void Start()
    {
        SpaceGameManager.activeObjects.Add((ICollisional)gameObject.GetComponent<Controller>());
    }

    void Update()
    {
        CheckCollision();
    }
}
