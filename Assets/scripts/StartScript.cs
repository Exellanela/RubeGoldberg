using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour {

	public Canvas startTextCanvas;
	Rigidbody RB;

	void Start() {
		RB = gameObject.GetComponent<Rigidbody> ();
		RB.isKinematic = true;
		startTextCanvas.enabled = true;
	}

	void Update() {
		if (Input.GetKey(KeyCode.Space)) {
			RB.isKinematic = false;
			startTextCanvas.enabled = false;
		}
	}
}
