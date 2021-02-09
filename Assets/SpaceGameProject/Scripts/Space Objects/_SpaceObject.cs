using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceObject : MonoBehaviour
{
    void Start()
    {
        SpaceGameManager.visibleObjects.Add(this.gameObject);
    }

    void OnDestroy()
    {
        SpaceGameManager.visibleObjects.Remove(this.gameObject);
    }
}
