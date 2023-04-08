using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Spawner : MonoBehaviour
{
    public GameObject[] car;
    public Vector3[] spawnLocation;
    private float spawntime = 1;
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
            SpawnCars();
        }
    }

void SpawnCars()
    {
        int i = Random.Range(0, car.Length);
        int j = Random.Range(0, spawnLocation.Length);
        Instantiate(car[i], spawnLocation[j], Quaternion.identity);
    }
}
