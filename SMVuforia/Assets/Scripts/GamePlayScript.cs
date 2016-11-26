﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GamePlayScript : MonoBehaviour {
    private float timeLeft;    
    public Button[] buttons = new Button[26];
    public Text textResult;

    // Use this for initialization
    void Start () {
        timeLeft = 0;
        textResult.text = "";
    }
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
            MenuPrincipal(); 
    }

    public void ButtonsAction(string value) {
        textResult.text = textResult.text + value;
    }

    public void MenuPrincipal() {
        SceneManager.LoadScene("Menu");
    }

}