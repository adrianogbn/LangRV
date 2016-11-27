using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GamePlayScript : MonoBehaviour {
    private float timeLeft;
    public Text textTimer;
    public Text textResult;

    public int objSize = 3;
    public GameObject[] objects = new GameObject[3];
    public string[] results = new string[3];

    private int currentObj;
    
    // Use this for initialization
    void Start () {
        for (int i = 0; i < objSize; i++)
            results[i] = results[i].ToUpper();
        sorteiaObject();
    }
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        textTimer.text = timeLeft.ToString();

        if (timeLeft >= 0) {
            if (textResult.text.Length <= results[currentObj].Length) {
                if (string.Equals(results[currentObj], textResult.text))
                    sorteiaObject();
            } else
                textResult.text = "";
        } else
            MenuPrincipal();
    }

    public void ButtonsAction(string value) {
        textResult.text = textResult.text + value;
    }

    public void MenuPrincipal() {
        SceneManager.LoadScene("Menu");
    }

    private void sorteiaObject() {
        for (int i = 0; i < objSize; i++)
            objects[i].SetActive(false);
        currentObj = Random.Range(0, 2);
        objects[currentObj].SetActive(true);
        timeLeft = 60;
        textResult.text = "";
    }
}