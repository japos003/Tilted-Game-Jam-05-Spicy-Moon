using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour {

    public GameObject _gameManager;
    private GameManagerScript _gameManagerScript;

    private Rigidbody _rigidBody;

	private void Awake()
	{
        _rigidBody = GetComponent<Rigidbody>();
        _gameManagerScript = _gameManager.GetComponent<GameManagerScript>();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter(Collision collision)
	{
        Debug.Log("collided...");
        if(collision.collider.tag == "Player"){
            Debug.Log("should disappear...");
            //TODO: Add to counter
            _gameManagerScript.AddChili();
            this.gameObject.active = false;
            Destroy(this);

        }
	}
}
