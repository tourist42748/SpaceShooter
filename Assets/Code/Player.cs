using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    public Projectile ProjectilePrefab;
    public float ShootInterval=2f;
    public float ShootTimer;
    public int Points;
    public Transform ShootPoint;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Move();
        Shoot();
        ShootTimer -= Time.deltaTime;
    }
    
    private void Move()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
           rigidbody.MovePosition(realPos);
        }
    }
    public void AddPoints(int count)
    {
        Points += count;
    }
    private void Shoot()
    {       
        if (ShootTimer <= 0)
        {
            Instantiate(ProjectilePrefab, ShootPoint.position, Quaternion.identity);
            ShootTimer = ShootInterval;
        }
    }
   
}
