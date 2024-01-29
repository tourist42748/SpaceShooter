using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject ExplosionEffect;
    public float BorderMin=2;
    public float BorderMax=5;
    public float RotationMax = 180f;
    public float RotationMin = 0f;

    private void Start()
    {
        ChangeScale();
        ChangeRotation();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            GameObject effect = Instantiate(ExplosionEffect, other.transform.position, other.transform.rotation);
            Destroy(effect, 5f);
            Destroy(gameObject);
        }
    }
    private void ChangeScale()
    {
        float randomScaleFactor = Random.Range(BorderMin, BorderMax);
        //transform.localScale=new Vector3(transform.localScale.x*randomScaleFactor, transform.localScale.y*randomScaleFactor);
        transform.localScale = transform.localScale * randomScaleFactor;
    }
    private void ChangeRotation()
    {
        float rotationFactor = Random.Range(RotationMin, RotationMax);
        transform.localEulerAngles = Vector3.forward * rotationFactor;
        
    }
}
