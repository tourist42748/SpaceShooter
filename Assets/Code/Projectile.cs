using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject ExplosionEffect;
    private float speed=10;
    void Start()
    {
        Destroy(gameObject, 5f);
    }
    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.up * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Obstacle")
        {
            Destroy(other.gameObject);
            GameObject effect = Instantiate(ExplosionEffect, transform.position, transform.rotation);
            Destroy(effect, 5f);
            Destroy(gameObject);
        }
    }
    
   
}
