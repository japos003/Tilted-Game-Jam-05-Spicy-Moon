﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

    public GameObject _chiliCounterUI;
    public int numOfChilis;

    private Text _chiliCounterMessage;

	private void Awake()
	{
        
	}

	// Use this for initialization
	void Start () {
        _chiliCounterMessage = _chiliCounterUI.GetComponent<Text>();
        numOfChilis = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddChili(){
        numOfChilis++;
        _chiliCounterMessage.text = "Chilis: " + numOfChilis;
    }
}
