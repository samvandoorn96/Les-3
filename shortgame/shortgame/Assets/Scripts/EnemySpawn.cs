using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject circleEnemy;
    public GameObject squareEnemy;
    public GameObject triangleEnemy;

    // Use this for initialization
    void Start () {
        StartCoroutine(loadEnemies());
	}
		
    private IEnumerator loadEnemies()
    {
        for (int i = 0; i < 10; i++)
        {
            print("Begin of for loop in: " + i);
            int choice = Random.Range(1, 4);
            Vector3 spawn = new Vector3(10, 0.0f, 0.0f);
            if (choice == 1)
            {
                Instantiate(circleEnemy, spawn, Quaternion.identity);
            }
            if(choice == 2)
            {
                Instantiate(triangleEnemy, spawn, Quaternion.identity);
            }
            if (choice == 3)
            {
                Instantiate(squareEnemy, spawn, Quaternion.identity);
            }
            yield return new WaitForSeconds(1);
            print("End of for loop in: " + i);

        }
    }
   
}
