using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : Factory
{
    public float radius;
    public float radiusMin;
    public GameObject enemy;
    public override GameObject Generate()
    {
        float r=Random.Range(radiusMin,radius);
        float angle=Random.Range(0,360);
        GameObject toGenerate=enemy;
        return Instantiate(
            toGenerate,
            new Vector3(
                r*Mathf.Sin(angle*Mathf.Deg2Rad)+mainShip.transform.position.x,
                2,
                r*Mathf.Cos(angle*Mathf.Deg2Rad)+mainShip.transform.position.z),
                Quaternion.identity);
    }
}
