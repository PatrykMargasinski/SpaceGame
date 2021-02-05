using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collision : MonoBehaviour
{
    public float radius;
    public abstract void CollisionReaction(Collision col);
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
        foreach(Collision col in SpaceGameManager.collisionalObjects)
        {
            bool isCollisionDistance=Vector3.Distance(GetPosition(), col.GetPosition()) <= GetRadius() + col.GetRadius();
            bool notSelfCollision=GetPosition()!=col.GetPosition();
            if(isCollisionDistance && notSelfCollision)
            {
                CollisionReaction(col);
                return;
            }
        }
    }
    void Start()
    {
        SpaceGameManager.collisionalObjects.Add(this);
    }

    void Update()
    {
        CheckCollision();
    }

    void OnDestroy()
    {
        bool success=SpaceGameManager.collisionalObjects.Remove(this);
    }
}
