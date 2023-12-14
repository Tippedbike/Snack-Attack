using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
private Rigidbody playerRb;
public float horizontalInput;
 private float forwardInput;
public float speed = 10.0f;
public float xRange = 12;
public float zRange = 12;
public int score = 0;
public ParticleSystem explosionParticles;
public AudioClip yummySound;
public AudioClip bombSound;
private AudioSource playerAudio;
public bool gameOver = false;

// Start is called before the first frame update
void Start()
{
    playerAudio = GetComponent<AudioSource>();
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
private void OnCollisionEnter(Collision collision)
   {
       if (collision.gameObject.CompareTag("Yummy"))
       {
          playerAudio.PlayOneShot(yummySound, 1.0f);
       }
       else if (collision.gameObject.CompareTag("Bomb"))
       {
           gameOver = true;
           Debug.Log("Game Over!");
           explosionParticles.Play(); 
           playerAudio.PlayOneShot(bombSound, 1.0f);
       }
      
   }
}