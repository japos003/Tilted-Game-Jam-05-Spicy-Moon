using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	void Awake(){
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float horizontal_movement = Input.GetAxis("Horizontal");//GetMovement();
        Debug.Log("movement:" + horizontal_movement);

        this.transform.position += new Vector3(horizontal_movement, 0, 0);
                                                  
	}

    //private float GetMovement(){
    //    if (Input.GetKeyDown(KeyCode.LeftArrow))
    //        return -1.0f;
    //    else if (Input.GetKeyDown(KeyCode.RightArrow))
    //        return 1.0f;

    //    return 0.0f;
    //}

    private float Jump(){
        return 0;
    }
}
