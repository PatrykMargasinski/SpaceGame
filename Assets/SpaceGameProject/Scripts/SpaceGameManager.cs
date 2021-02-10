using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceGameManager : MonoBehaviour
{
    public GameObject player;
    AsteroidFactory asteroidFactory;
    public float radius;
    public float radiusMin;
    public float disappearingRadius;
    public float maxGenerationValue=0f;
    private float generationValue=0f;
    private int counter=0;
    public int maxAmount;
    static public List<GameObject> visibleObjects;
    static public List<Collision> collisionalObjects;

    void Awake()
    {
        collisionalObjects=new List<Collision>();
        visibleObjects=new List<GameObject>();
    }

    void Start()
    {
        asteroidFactory=GetComponent<AsteroidFactory>();
    }

    void Update()
    {
        if(counter<maxAmount)
        {
            generationValue+=Time.deltaTime;
        }
        if(generationValue>=maxGenerationValue)
        {
            counter++;
            asteroidFactory.Generate();
            generationValue=0;
        }
    }
}
