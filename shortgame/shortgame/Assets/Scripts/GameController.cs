using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour {
    public GameObject Player;
    public Vector3 SpawnLocation;
    public Text gameOverText;
    public Text restartText;
    public bool playerDied;
    public bool playerDiedAck;
	// Use this for initialization
	void Start () {
        Instantiate(Player, SpawnLocation, Quaternion.identity);
        playerDied = false;
        playerDiedAck = false;
        gameOverText.text = "";
        restartText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
        //GameObject player = GameObject.Find("Player");
        //PlayerController pc = player.GetComponent<PlayerController>();
        if (playerDied && !playerDiedAck)
        {
            playerDies();
            playerDiedAck = true;
        }
        if (Input.GetKey(KeyCode.R) && playerDied)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
	}

    void playerDies()
    {
        gameOverText.text = "Game Over!";
        restartText.text = "Press 'R' to restart";
    }
}
