using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    int scoreToAdd = 0;
    public AudioClip yummySound;
    private AudioSource playerAudio; 
    public bool gameOver = false;
    
// Start is called before the first frame update
void Start()
{ 
    playerAudio = GetComponent<AudioSource>();
}
void OnTriggerEnter(Collider other)
{
if(other.CompareTag("Player"))
{
     PlayerController pc = other.GetComponent<PlayerController>();
     Destroy(gameObject);
     pc.score += scoreToAdd;
     pc.explosionParticles.Play(); 
}
}
// Update is called once per frame
void Update()
{
}
}



