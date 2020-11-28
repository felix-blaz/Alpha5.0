using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private GameManager gameManager;
    public float speed;
    private Rigidbody playerRb;
    public bool hasPowerup;
    public bool died;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");

       //playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            Debug.Log ("Player has power up");

        }
        else if (other.CompareTag("meteor"))
        {
            died = true;
            Destroy(gameObject);
            Debug.Log ("Player was hit by a meteor and died");
           gameManager.GameOver();
        }
        else if (other.CompareTag("Bolder"))
        {
            died = true;
            Destroy(gameObject);
            Debug.Log("Player was hit by a bolder and died");
            gameManager.GameOver();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("meteor") && hasPowerup)
        {
            Debug.Log("Player collided with meteor with powerupset to" + hasPowerup);
        }
    }
}
