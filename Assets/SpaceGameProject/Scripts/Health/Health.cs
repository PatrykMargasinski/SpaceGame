using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public GameObject canvas;
    public GameObject healthBarPrefab;
    private GameObject healthBar;
    private GameObject healthSlider;
    void Start()
    {
        var healthBarContainer=Instantiate(
            healthBarPrefab,
            gameObject.transform.position,
            Quaternion.identity
            );
        healthBarContainer.transform.SetParent(canvas.transform);
    }    

    void Update()
    {

    }
}
