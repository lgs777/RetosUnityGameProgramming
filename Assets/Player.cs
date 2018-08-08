﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


	public int speed = 10;
	public Rigidbody PlayerRigidbody;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            PlayerRigidbody.AddForce(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            PlayerRigidbody.AddForce(0, 0, -speed);
        }


    }
}
