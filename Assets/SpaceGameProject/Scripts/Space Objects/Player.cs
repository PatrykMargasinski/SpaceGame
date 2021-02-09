using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : SpaceObject
{
    void Start()
    {

    }
    void Update()
    {
        
    }

    void OnDestroy()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
