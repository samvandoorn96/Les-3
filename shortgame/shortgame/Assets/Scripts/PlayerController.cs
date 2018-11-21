using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour {
    public bool died;
    public Vector3 spawn;
    public float fireRate;
    private float nextFire;
    public GameObject CircleShot;
    // Use this for initialization
    void Start () {
        died = false;
	}
	
	// Update is called once per frame
	void Update () {
        
        
            if (Input.GetButton("Fire1") && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(CircleShot, spawn, Quaternion.identity);
            }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        died = true;
        GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().playerDied = true;
        gameObject.SetActive(false);
        
    }
}
