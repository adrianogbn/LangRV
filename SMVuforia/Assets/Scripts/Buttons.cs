using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Buttons : MonoBehaviour {
    public Text textResult;

	// Use this for initialization
	void Start () {
        textResult.text = "";
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void click(string value) {
        textResult.text.Insert(textResult.text.Length-1,value);
    }   
}
