using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleShotController : MonoBehaviour {
    public Vector3 speed;
    
    // Use this for initialization
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
