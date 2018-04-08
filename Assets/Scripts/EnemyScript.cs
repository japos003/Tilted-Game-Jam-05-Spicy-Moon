using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    Rigidbody _rigidBody;
    public float _changeDirectionTime;
    public float _enemyMovementSpeed;

    private float _changeDirectionCurrentTime;
    private float _enemyDirection;

	private void Awake()
	{
        _rigidBody = GetComponent<Rigidbody>();
	}

	// Use this for initialization
	void Start () {
        _changeDirectionCurrentTime = _changeDirectionTime;
        _enemyDirection = _enemyMovementSpeed;
	}
	
	// Update is called once per frame
	void Update () {
        _changeDirectionCurrentTime -= Time.deltaTime;

        if(_changeDirectionCurrentTime <= 0){
            _changeDirectionCurrentTime = _changeDirectionTime;
            _enemyDirection = -_enemyDirection;
        }

        this.transform.position += new Vector3(_enemyDirection * Time.deltaTime, 0, 0);
	}
}
