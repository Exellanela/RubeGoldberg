using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour {

	//public Transform lookOverride;
	public Transform moveOverride;

	void OnTriggerEnter(Collider c) {
		CameraControl camControlScript = Camera.main.GetComponent<CameraControl> ();

		if (moveOverride != null) {
			camControlScript.moveToTarget = moveOverride;
		}

		/*
		if (lookOverride != null) {
			camControlScript.lookAtTarget = lookOverride;
		}
		*/
	}
}
