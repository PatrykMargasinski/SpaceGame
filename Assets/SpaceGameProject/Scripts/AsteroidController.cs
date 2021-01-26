using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    Movement movement;

    void Start()
    {
        movement=GetComponent<Movement>();
    }
}
