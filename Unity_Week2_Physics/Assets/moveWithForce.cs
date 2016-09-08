using UnityEngine;
using System.Collections;

public class moveWithForce : MonoBehaviour {

    // calling certain elements we're going to need, a call to adjust speed and a call to identify the rigidbody
    float acceleration = 10;
    Rigidbody thisRB;

	// Use this for initialization
	void Start () {

        // loads up the rigidbody and gets it ready for use in the update section
        thisRB = GetComponent<Rigidbody>();
        	
	}
	
	// Update is called once per frame
	void Update () {
        // this line gets your object to move right and left, and understand the acceleration/speed you want
        // thisRB is the rigidbody on the object and AddForce is adding the force/movement
       thisRB.AddForce( Vector3.right * Input.GetAxis( "Horizontal" ) * acceleration);
        // this line does the same as above, but instead of moving right or left, this line moves the object up and down
       thisRB.AddForce( Vector3.up * Input.GetAxis( "Vertical" ) * acceleration );
    }
}
