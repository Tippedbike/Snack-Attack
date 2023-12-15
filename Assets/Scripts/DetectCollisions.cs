using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    int scoreToAdd;
    
// Start is called before the first frame update
void Start()
{ 

}
 void OnTriggerEnter(Collider other)
{
if(other.CompareTag("Player"))
{
     PlayerController pc = other.GetComponent<PlayerController>();
     Destroy(gameObject);
     pc.score += scoreToAdd;
     Debug.Log(pc.score);
}
}
// Update is called once per frame
void Update()
{
}
}



