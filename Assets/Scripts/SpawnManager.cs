using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
public GameObject[] yummyPrefabs;
private float spawnRangeX = 10;
private float spawnRangeZ = 10;
private float spawnPosY = 25;
private float startDelay = 2;
private float spawnInterval = 1.5f;


// Start is called before the first frame update
void Start()
{
InvokeRepeating("SpawnRandomYummy", startDelay, spawnInterval);
}
void SpawnRandomYummy()
{
int yummyIndex = Random.Range(0, yummyPrefabs.Length);
Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),spawnPosY, Random.Range(-spawnRangeZ, spawnRangeZ ));
Instantiate(yummyPrefabs[yummyIndex], spawnPos, yummyPrefabs[yummyIndex].transform.rotation);
}
// Update is called once per frame
void Update()
{
}
}