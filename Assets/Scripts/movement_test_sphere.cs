﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_test_sphere : MonoBehaviour {

    Rigidbody rb;
    float speedX;
    float speedZ;
	// Use this for initialization
	void Start () {
        rb = (Rigidbody)GetComponent("Rigidbody");
	}
	
	// Update is called once per frame
	void Update () {
        speedX = 0;
        speedZ = 0;
        if (Input.GetKey(KeyCode.D))
            speedX += 15;
        if (Input.GetKey(KeyCode.A))
            speedX -= 15;
        if (Input.GetKey(KeyCode.W))
            speedZ += 15;
        if (Input.GetKey(KeyCode.S))
            speedZ -= 15;

        rb.velocity = new Vector3(speedX, 0, speedZ);
    }
}
