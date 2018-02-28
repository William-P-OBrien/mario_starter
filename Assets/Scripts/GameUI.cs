using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

    public Text scoreText;
    public Text pauseScore;
    public int score = 0;
    int highScore;
    // Use this for initialization
    void Start () {
		highScore = PlayerPrefs.GetInt("score", 0);
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + score;
        pauseScore.text = "Current Score: " + score;
        if (score > highScore)
            PlayerPrefs.SetInt("score", score);
	}
}
