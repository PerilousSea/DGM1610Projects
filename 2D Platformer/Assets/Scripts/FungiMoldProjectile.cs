using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FungiMoldProjectile : MonoBehaviour
{
    public float Speed = 30.0f;
    public int damage = 1;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += -transform.right * Time.deltaTime * Speed;
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Enemy took damage!");
        Enemy enemy = other.GetComponent<Enemy>();
        if(other.gameObject.CompareTag("Enemy"))
        {
                enemy.TakeDamage(damage);
                Destroy(gameObject);
        }
        
    }
}
