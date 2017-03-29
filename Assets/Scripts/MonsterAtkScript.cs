using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAtkScript : MonoBehaviour {
	 Animator anim;

	void Start () {
		anim = this.GetComponent<Animator>();
	}
	
	// コライダー衝突時に攻撃アニメーション
	void OnTriggerEnter(Collider other){
		if(other.name == "Target"){
			
			anim.SetBool ("Atack_1", true);
		}
	}

	public void Attacked() {
		anim.SetBool ("Die",true);

	}

	}
