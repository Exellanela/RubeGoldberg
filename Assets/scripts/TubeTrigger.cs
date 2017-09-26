using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeTrigger : MonoBehaviour {
	
	public GameObject boxTrig;


	void Awake() {
		boxTrig.SetActive (false);
	}

	void OnTriggerEnter(Collider c) {
		boxTrig.SetActive (true);
	}
}
