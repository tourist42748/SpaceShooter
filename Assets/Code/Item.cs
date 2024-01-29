using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject PickUpEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            player.AddPoints(1);
            GameObject effect = Instantiate(PickUpEffect, transform.position, transform.rotation);
            Destroy(effect, 5f);
            Destroy(gameObject);
        }
    }
}
