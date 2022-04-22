using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public float pHealth = 100;
    public Text HP;

    public GameManager gameManager;

    public void Hit(float zDamage)
    {
        pHealth -= zDamage;
        HP.text = "HP: " + pHealth.ToString();

        if(pHealth <= 0)
        {
            gameManager.EndGame();
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
