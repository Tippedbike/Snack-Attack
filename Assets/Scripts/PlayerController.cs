using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
private Rigidbody playerRb;

public float xRange = 12;
public float zRange = 12;
//boundaries for fun :)

public float horizontalInput;
private float forwardInput;
//movement 

public float speed = 10.0f;

public ParticleSystem explosionParticles;

private AudioSource playerAudio;
public AudioClip yummySound;
public AudioClip bombSound;
//sound

public int score = 0;
// Start is called before the first frame update
void Start()
{
    playerAudio = GetComponent<AudioSource>(); //gets audio comp
    playerRb = GetComponent<Rigidbody>();
}
// Update is called once per frame
void Update()
{
    //movement
horizontalInput = Input.GetAxis("Horizontal");
forwardInput = Input.GetAxis("Vertical");
transform. Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

//keeps player from going out of bounds
if (transform.position.x < -xRange)
{
transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
}
if (transform.position.x > xRange)
{
transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
}

if (transform.position.z < -zRange)
{
transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
}
if (transform.position.z > zRange)
{
transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
}
}
void OnCollisionEnter(Collision other)
   {
       if (other.gameObject.CompareTag("Yummy"))
       {
          playerAudio.PlayOneShot(yummySound, 1.0f);
       }
       else if (other.gameObject.CompareTag("Bomb"))
       {
           explosionParticles.Play(); 
           playerAudio.PlayOneShot(bombSound, 1.0f);
       }
      
   }
}