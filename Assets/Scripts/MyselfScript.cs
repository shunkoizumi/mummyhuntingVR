using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MyselfScript : MonoBehaviour {
	public int life ;
	int attackPower;
	GameObject hpGauge;
	Slider slider;
	 Image panel;
 
	void Start () {
		life = 3;
		slider = GameObject.Find ("Slider").GetComponent<Slider> ();
		panel = GameObject.Find ("Panel").GetComponent<Image> ();
	}
	

	void Update () {
		
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.name == "sword1") {
			attackPower = other.GetComponent<WeaponScript> ().attackPower;
			ScoreController obj = GameObject.Find ("Dive_Camera").GetComponent<ScoreController> ();
			obj.SaveHighScore ();
			life -= attackPower;
			slider.value = life;
			panel.enabled = true;
			Invoke ("ColorFalse", 0.5f);
			Invoke ("ReturnTitle", 1.0f);


		}
	}
		
	void ColorFalse(){
		panel.enabled = false;
	}

	void ReturnTitle(){
		if (life <= 0) {
			SceneManager.LoadScene ("Title");
		}
	}

}

