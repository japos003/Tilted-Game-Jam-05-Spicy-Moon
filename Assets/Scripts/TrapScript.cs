using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour {

    public GameObject _gameManager;
    public GameObject _player;

    public Vector3 _startPosition;

    private GameManagerScript _gameManagerScript;

    private void Awake()
	{
        _gameManagerScript = _gameManager.GetComponent<GameManagerScript>();
	}
	// Use this for initialization
	void Start () {
		
	}

	private void OnCollisionEnter(Collision collision)
	{
        Debug.Log("collided with trap");
        if(collision.collider.tag == "Player"){
            _gameManagerScript.LoseLife();

            _player.transform.position = _startPosition;
        }
	}

	// Update is called once per frame
	void Update () {
		
	}
}
