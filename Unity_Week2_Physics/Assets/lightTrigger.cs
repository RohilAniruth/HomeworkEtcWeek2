using UnityEngine;
using System.Collections;

public class lightTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
    }

    //when something enters the Trigger attached to this gameObject
        void OnTriggerEnter() {
        // get the light attached to game object
        // turn light on
        //functions need perenthesis
        GetComponent<Light>().enabled = true;
     


        //GetComponent<Light>().color = Color.cyan; ALT LIGHT FUNCTION TO KEEP LIGHT ON


    }

    // get light to turn off when you leave
    void OnTriggerExit()
    {
        GetComponent<Light>().enabled = false;
      
        //GetComponent<Light>().color = Color.magenta; ALT LIGHT FUNCTION TO KEEP LIGHT ON
    }


    }
