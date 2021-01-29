using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : Controller, ICollisional
{
    public GameObject owner;
    public float radius;
    bool activation;
    void Awake()
    {
        movement=GetComponent<Movement>();
        SpaceGameManager.activeObjects.Add(this);
    }
    void Update()
    {
        CheckCollision();
    }
    void OnDestroy()
    {
        SpaceGameManager.activeObjects.Remove(this);
    }
    public Vector3 GetPosition()
    {
        return transform.position;
    }
    public float GetRadius()
    {
        return radius;
    }
    public GameObject GetGameObject()
    {
        return gameObject;
    }
    public void CollisionReaction(Movement colMovement)
    {
        Debug.Log("Collision reaction: Projectile with "+ colMovement.gameObject.name);
    }
    public void CheckCollision()
    {
        foreach(ICollisional col in SpaceGameManager.activeObjects)
        {
            if(Vector3.Distance(GetPosition(),col.GetPosition())<=GetRadius()+col.GetRadius() && col!=(ICollisional)this && col.GetGameObject()!=owner)
            {
                col.CollisionReaction(this.movement);
                return;
            }
        }
    }
}
