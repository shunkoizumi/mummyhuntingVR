using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelFlash : MonoBehaviour {
	public Image panel_flashMonitor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator monitorFlash(){
		panel_flashMonitor.enabled = true;
		yield return new WaitForSeconds(0.1f);		
		panel_flashMonitor.enabled = false;
	}
}
