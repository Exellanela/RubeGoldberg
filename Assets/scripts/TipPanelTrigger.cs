using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//put on trigger
public class TipPanelTrigger : MonoBehaviour {

	//triggers balls being dropped onto the panels

	public GameObject ball;
	//public GameObject trigBall;
	Rigidbody ball01RB;

		
	void Start() {
		ball01RB = ball.GetComponent<Rigidbody> ();
		ball01RB.isKinematic = true;
	}

	void OnTriggerEnter(Collider c) {
		if (c.gameObject.tag == "TriggerBall") {
			ball01RB.isKinematic = false;
		}
	}
}
