using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {
	AudioSource sound1;

	void Start () {
		
		sound1 = GetComponent<AudioSource>();
	}
	

	void Update () {
		
	}

	public void ShotSound(){
		sound1.PlayOneShot (sound1.clip);
	}
}
