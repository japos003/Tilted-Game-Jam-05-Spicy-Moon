using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

    public GameObject _chiliCounterUI;
    public int numOfChilis;
    public int playerLives;

    private Text _chiliCounterMessage;

	private void Awake()
	{
        
	}

	// Use this for initialization
	void Start () {
        _chiliCounterMessage = _chiliCounterUI.GetComponent<Text>();
        numOfChilis = 0;
        playerLives = 3;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddChili(){
        numOfChilis++;
        _chiliCounterMessage.text = "Chilis: " + numOfChilis;
    }

    public int LoseLife(){
        playerLives--;
        Debug.Log("lose life");
        return playerLives;
    }
}
