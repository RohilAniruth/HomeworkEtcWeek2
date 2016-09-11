﻿using UnityEngine;
using System.Collections;

public class trapDoor3 : MonoBehaviour {

    float rotationSpeed = -5;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // if i hit a specific key, open the trap door
        // Input.GetKey ... is how you get keys. 
        if (Input.GetKey(KeyCode.L))
        {
            // if key 'l' is hit
            print("open trapdoor");

            // rotate to -90 degrees
            // by rotation speed

            transform.Rotate(Vector3.up * rotationSpeed);
        }
    }
}

