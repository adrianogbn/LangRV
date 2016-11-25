using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    
	}

    public void NovoJogo () {
        SceneManager.LoadScene("scene");
    }

    public void Sair () {
        Application.Quit();        
    }

    public void MenuVoltar () {
        SceneManager.LoadScene("Menu");
    }
}
