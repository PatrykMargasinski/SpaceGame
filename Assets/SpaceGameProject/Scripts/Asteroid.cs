using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour, ICollisional
{
    Movement movement;
    void Start()
    {
        SpaceGameManager.activeObjects.Add(this);
        movement=GetComponent<Movement>();
    }
    public Vector3 GetPosition()
    {
        return new Vector2(transform.position.x,transform.position.z);
    }

    public float GetRadius()
    {
        return 0.5f;
    }

    public void CollisionReaction(Movement colliderMovement)
    {
        colliderMovement.SetNews(-colliderMovement.moveX,-colliderMovement.moveY);
    }

    void OnDestroy()
    {
        SpaceGameManager.activeObjects.Remove(this);
    }

    void OnDisable()
    {
        SpaceGameManager.activeObjects.Remove(this);
    }
}
