using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleEnemyController : MonoBehaviour {
    public Vector3 speed;
    // Use this for initialization
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
    }

    
}
