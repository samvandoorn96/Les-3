using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour {
    public bool died;
	// Use this for initialization
	void Start () {
        died = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        died = true;
        GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().playerDied = true;
        gameObject.SetActive(false);
        
    }
}
