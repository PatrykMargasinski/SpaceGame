using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Factory : MonoBehaviour
{
    public GameObject mainShip;
    public abstract GameObject Generate();
}
