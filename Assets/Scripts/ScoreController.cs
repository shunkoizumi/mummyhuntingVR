using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour {
	public Text ScoreText;
	public int score;
	public Text HighScore;


	void Start () {
		score = 0;
		if (SceneManager.GetActiveScene ().name == "Title") {
			HighScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0);
		}
	}	

	void Update () {
		if (SceneManager.GetActiveScene ().name == "ssshoo") {
			ScoreText.text = "Score: " + score;
		}
	}
	//スコアを2秒後に反映
	public void ScorePlus(){
		Invoke ("CalculateScore", 2f);
	}

   void CalculateScore(){
		score += 10;
}
	public void SaveHighScore ()
	{

		if (PlayerPrefs.GetInt ("HighScore", 0) < score) {
			PlayerPrefs.SetInt ("HighScore", score);

		}
	}

	}


