using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceGameManager : MonoBehaviour
{
    static public List<ICollisional> activeObjects;
    void Awake()
    {
        activeObjects=new List<ICollisional>();
    }
}
