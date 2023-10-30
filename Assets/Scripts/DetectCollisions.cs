using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    int scoreToAdd = 0;
    
// Start is called before the first frame update
void Start()
{ 
}
void OnTriggerEnter(Collider other)
{
if(other.CompareTag("Player"))
{
PlayerController pc = other.GetComponent<PlayerController>();
pc.score += scoreToAdd;
Destroy(gameObject);
}
}
// Update is called once per frame
void Update()
{
}
}

