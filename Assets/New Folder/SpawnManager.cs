using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public bool enableSpawn = false;
    public GameObject Enemy;
    void SpawnEnemy()
    {
        float randomX = Random.Range(-50f, 50f);
        if(enableSpawn)
        {
            GameObject cat = (GameObject)Instantiate(Enemy, new Vector3(randomX, 1.1f, 0f), Quaternion.identity);
        }

    }
	// Use this for initialization
	void Start () {

        InvokeRepeating("SpawnEnemy", 3, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
