using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceObject : MonoBehaviour
{
    void Start()
    {
        SpaceGameManager.visibleObjects.Add(this.gameObject);
    }
    protected Shooting shooting;
    protected Movement movement;
    protected Collision collision;

    void OnDestroy()
    {
        //SpaceGameManager.visibleObjects.Remove(this.gameObject);
    }
}
