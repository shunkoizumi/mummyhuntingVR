using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationScript : MonoBehaviour {
	public GameObject target;

	void Start () {
		 NavMeshAgent agent = GetComponent<NavMeshAgent> ();
		agent.speed = 3;
		agent.destination = target.transform.position;

		
	}
	

	void Update () {
		
	}
}
