using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour, ICollisional
{
    public float radius;
    Movement movement;
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
        Debug.Log("HJ");
        SpaceGameManager.activeObjects.Remove(this);
    }
    // Start is called before the first frame update
    public Vector3 GetPosition()
    {
        return transform.position;
    }
    public float GetRadius()
    {
        return radius;
    }
    public void CollisionReaction(Movement colMovement)
    {
        //if(colMovement.gameObject.tag!="Player")
        //    Destroy(colMovement.gameObject);
    }
    public void CheckCollision()
    {
        foreach(ICollisional col in SpaceGameManager.activeObjects)
        {
            if(Vector3.Distance(GetPosition(),col.GetPosition())<=GetRadius()+col.GetRadius())
            {
                col.CollisionReaction(this.movement);
                return;
            }
        }
    }
}
