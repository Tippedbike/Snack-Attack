using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
public GameObject[] yummyPrefabs;
private float spawnRangeX = 20;
private float spawnPosZ = 20;
private float startDelay = 2;
private float spawnInterval = 1.5f;


// Start is called before the first frame update
void Start()
{
InvokeRepeating("SpawnRandomYummy", startDelay, spawnInterval);
}
void SpawnRandomYummyl()
{
int yummyIndex = Random.Range(0, yummyPrefabs.Length);
Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0, spawnPosZ);
Instantiate(yummyPrefabs[yummyIndex], spawnPos, yummyPrefabs[yummyIndex].transform.rotation);
}
// Update is called once per frame
void Update()
{
}
}