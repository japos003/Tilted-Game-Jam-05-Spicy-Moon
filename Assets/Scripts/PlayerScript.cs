using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    private float _airPosition;
    private bool _inAir = false;

	void Awake(){
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        float horizontal_movement = Input.GetAxis("Horizontal");



        this.transform.position += new Vector3(horizontal_movement, 0, 0);
                                                  
	}

    private float Jump(){

        if (Input.GetKey(KeyCode.Space))
        {

        }
    }
}
