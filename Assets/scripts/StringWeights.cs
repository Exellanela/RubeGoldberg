using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//put on trigger above weights
public class StringWeights : MonoBehaviour {

	public GameObject weight;
	Rigidbody weightRB;


	void Start() {
		weightRB = weight.GetComponent<Rigidbody> ();
		weightRB.isKinematic = true;
	}

	void OnTriggerEnter(Collider c) {
		if (c.gameObject.tag == "TriggerBall") {
			weightRB.isKinematic = false;
		}
	}
}
