using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

    public GameObject[] enemies;
    public int enemyCount;
    private Vector3 spawnPoint;

    public static clientTcp mess;
    private string msg;


	// Use this for initialization
	void Start () {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        enemyCount = enemies.Length;

	}
	
	// Update is called once per frame
	void Update () {

        msg = clientTcp.mess;


        if (msg.Contains("Spawn"))
        {
            InvokeRepeating("SpawnEnemy", 1, 2);
        }
	
	}

    void SpawnEnemy()
    {
        spawnPoint.x = Random.Range(-10, 10);
        spawnPoint.y = 5f;
        spawnPoint.z = Random.Range(-10, 10);

        Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length - 1)], spawnPoint, Quaternion.identity);
        CancelInvoke();
    }
}
