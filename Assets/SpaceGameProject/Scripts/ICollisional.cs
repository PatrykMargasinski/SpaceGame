using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollisional
{
    Vector3 GetPosition();
    float GetRadius();
    void CollisionReaction(Movement movement);
}
