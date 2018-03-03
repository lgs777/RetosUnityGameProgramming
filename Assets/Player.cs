using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 10f;
    public Rigidbody playerRigidbody;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerRigidbody.AddForce(0, 0, speed);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerRigidbody.AddForce(-speed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))    
        {
            playerRigidbody.AddForce(0, 0, -speed);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerRigidbody.AddForce(speed, 0, 0);
        }*/

        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        //  playerRigidbody.AddForce(speed * inputX, 0, speed * inputZ);
        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        float fallSpeed = playerRigidbody.velocity.y;

        // (inputX * speed, 0, inputZ * speed)
        velocity = velocity * speed;
        velocity.y = fallSpeed;
        playerRigidbody.velocity = velocity;
        
	}
}
