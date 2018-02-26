using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
    public string levelName;
    public Text scoreText;
    int score;

	// Use this for initialization
	void Start () {
        //PlayerPrefs.SetInt("score", 10);//Just here for testing
        score = PlayerPrefs.GetInt("score", 0);
        scoreText.text = "High Score: " + score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void play()
    {
        SceneManager.LoadScene(levelName);
    }
}
