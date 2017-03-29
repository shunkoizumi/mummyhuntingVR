using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartRayController : MonoBehaviour {

	public GameObject diveCamera;
	GameObject[] changeImages;
	float gazedTime;
	public GameObject refObj1;
	SoundController sound;
	private bool isHitRay;

	void Start () {
		changeImages = GameObject.FindGameObjectsWithTag ("changecolor");
		sound  = refObj1.GetComponent<SoundController> ();
	}
	

	void Update ()
	{
		Ray ray = new Ray (diveCamera.transform.position, diveCamera.transform.forward);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit)) {
			
			if (hit.collider.gameObject.tag == "changecollider") {
				if (!isHitRay) {
					// 一度もヒットしていないなら処理を行う
					isHitRay = true; // ヒットした
					for (int i = 0; i < changeImages.Length; i++) { 
						changeImages [i].GetComponent<Image> ().color = Color.white;
					}
					sound.ShotSound ();
					hit.collider.gameObject.transform.parent.GetComponent<Image> ().color = Color.red;
					Invoke ("GameStart", 3f);
				}
			
			} 
		}
	}



	public void GameStart(){
		SceneManager.LoadScene ("ssshoo");
	}
}
