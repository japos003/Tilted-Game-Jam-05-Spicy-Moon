using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    enum JumpStatus{
        ONGROUND,
        ONAIR
    }

    private static float ORIGINAL_FLOAT_SPEED = 400.0f;

    private SpriteRenderer _spriteRenderer;
    private GameManagerScript _gameManagerScript;
    private Rigidbody _rigidBody;
    private int _timesToJump;
    private float _airPosition;
    private bool _inAir = false;

    public float _speed;

	void Awake(){
        _rigidBody = GetComponent<Rigidbody>();

        var spriteObject = this.transform.Find("PlayerMovementSprite");
        _spriteRenderer = spriteObject.GetComponent<SpriteRenderer>();
	}

	// Use this for initialization
	void Start () {
        _airPosition = 100.0f;
        _timesToJump = 2;
        _speed = 10.0f;
	}
	
	// Update is called once per frame
	void Update () {
        
        float horizontal_movement = Input.GetAxis("Horizontal");

        if (horizontal_movement < 0)
            _spriteRenderer.flipX = true;
        else if (horizontal_movement > 0){
            _spriteRenderer.flipX = false;
        }

        Jump();

        this.transform.position += new Vector3(horizontal_movement * _speed * Time.deltaTime, 0, 0);
                                                  
	}

	private void OnCollisionEnter(Collision collision)
	{
        // TODO: implement a tag for the floor
        if(collision.collider.tag == "Floor"){
            _inAir = false;
            _timesToJump = 2;
            _airPosition = ORIGINAL_FLOAT_SPEED;
        }
	}

	private float Jump(){
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(_timesToJump > 0){
                Debug.Log(_timesToJump);
                _rigidBody.AddForce(new Vector3(0, ORIGINAL_FLOAT_SPEED, 0));
                _timesToJump--;
            }

        }
        else {
            _airPosition = ORIGINAL_FLOAT_SPEED;
        }


        return 0.0f;
    }
}
