using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour
{
    public GameObject player;
    public Animator enemyAnimator;
    public float zDamage = 10f;
    public float zHealth = 90f;
    public GameManager gameManager;

    public void Hit(float gDamage)
    {
        zHealth -= gDamage;      
    }
    public void TurretHit(float tDamage)
    {
        zHealth -= tDamage;
    }
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void Update()
    {
        GetComponent<NavMeshAgent>().destination = player.transform.position;
        if(GetComponent<NavMeshAgent>().velocity.magnitude > 1)
        {
            enemyAnimator.SetBool("isRunning", true);
        }
        else
        {
            enemyAnimator.SetBool("isRunning", false);
        }

        if (zHealth <= 0)
        {
            gameManager.enemiesAlive--;
            Destroy(gameObject); //Destory the zombie

            gameManager.GetMoney();
        }
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            player.GetComponent<PlayerManager>().Hit(zDamage);
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            player.GetComponent<PlayerManager>().Hit(zDamage);
        }
    }
}
