using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasTrigger : MonoBehaviour {

	public Canvas textCanvas;

	public GameObject thing01;
	public GameObject thing02;
	public GameObject thing03;

	void Awake() {
		textCanvas.enabled = false;
		thing01.SetActive (false);
		thing02.SetActive (false);
		thing03.SetActive (false);
	}

	void OnTriggerEnter(Collider c) {
		textCanvas.enabled = true;
		thing01.SetActive (true);
		thing02.SetActive (true);
		thing03.SetActive (true);
	}
}
