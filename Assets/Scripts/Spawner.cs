using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnInterval = 0.5f;
    public float maxYOffset = 4.5f;

    private void Start()
    {
        InvokeRepeating("Spawn", 0, spawnInterval);
    }

    private void Update()
    {
    }

    void Spawn()
    {
        var yOffset = Random.Range(-maxYOffset, maxYOffset);
        Instantiate(objectToSpawn, transform.position + new Vector3(0, yOffset), Quaternion.identity);    
    }
}
