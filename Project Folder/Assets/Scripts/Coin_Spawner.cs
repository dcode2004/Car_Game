using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Spawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public Vector3[] spawnLocation;
    public float spawntime;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawntime)
            timer += Time.deltaTime;
        else
        {
            timer = 0;
            SpawnCoins();
        }
    }

    void SpawnCoins()
    {
        int j = Random.Range(0, spawnLocation.Length);
        Instantiate(coinPrefab, spawnLocation[j], Quaternion.identity);
    }
}
