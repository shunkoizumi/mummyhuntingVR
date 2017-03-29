using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {
	Animator anim;

	void Start () {
		anim = this.GetComponent<Animator>();
	}
	

	void Update () {
		
	}
	public void GunTrigger(){
		anim.SetBool ("Shot1",true);
	}
}