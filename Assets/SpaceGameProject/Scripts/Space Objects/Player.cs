using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : SpaceObject
{
    void Start()
    {
        movement=gameObject.GetComponent<Movement>();
        shooting=gameObject.GetComponent<Shooting>();
        collision=GetComponent<Collision>();
    }
    void Update()
    {
        //KeyboardReader();
    }

    void OnDestroy()
    {
        Debug.Log("Hej");
        SceneManager.LoadScene("GameOverScene");
         Debug.Log("Hej2");
    }
}
