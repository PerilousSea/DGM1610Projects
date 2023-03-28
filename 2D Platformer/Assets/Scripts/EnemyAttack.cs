using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private PlayerHealth playerHealth;
    public int damage = 1;

    void Start()
    {
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        playerHealth.TakeDamage(damage);
        Debug.Log("Player Takes " + damage + " points of damage");
    }
}
 
 
