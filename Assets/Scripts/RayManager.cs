using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RayManager : MonoBehaviour {

	public GameObject dive_Camera;
	public float gazedTime;
	Slider slider;
	int playerlife;
	public GameObject refObj;
	SoundController sound;
	GunController gunControll;

	void Start(){
		
		slider = GameObject.Find ("Slider").GetComponent<Slider> ();
		sound  = refObj.GetComponent<SoundController> ();
		gunControll =  refObj.GetComponent<GunController> ();
	}

	void Update () {
		Ray ray = new Ray (dive_Camera.transform.position, dive_Camera.transform.forward);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit)) {

			if (hit.collider.tag == "monster") {

				MonsterAtkScript monsterAtkScript = hit.transform.GetComponent<MonsterAtkScript> ();




				gazedTime += Time.deltaTime;

				if (gazedTime >= 0.8f) {
					gunControll.GunTrigger ();
					sound.ShotSound ();

					monsterAtkScript.Attacked ();
					Destroy (hit.collider.gameObject, 0.79f);
					gazedTime = 0;
					ScoreController obj = GameObject.Find ("Dive_Camera").GetComponent<ScoreController>();
					obj.ScorePlus ();
				}
			} else {
				gazedTime = 0;
			}
		}


	}

		}