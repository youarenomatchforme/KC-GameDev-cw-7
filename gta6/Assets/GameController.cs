using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform spawnMid;
    public Transform spawnMin;
    public Transform spawnMax;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        int randomPos = Random.Range(1, 3);
        Instantiate(enemy, spawnMax);
    }

}
