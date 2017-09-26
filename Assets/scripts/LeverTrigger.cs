using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverTrigger : MonoBehaviour {

	public GameObject lever1;

	Rigidbody lev1RB;


	void Start() {
		lev1RB = lever1.GetComponent<Rigidbody> ();
		lev1RB.isKinematic = true;
	}


	void OnTriggerEnter(Collider c) {
		lev1RB.isKinematic = false;
	}
}
