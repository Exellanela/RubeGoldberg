using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//put on trigger to open door
public class BubDoorTrigger : MonoBehaviour {

	public GameObject glassDoor;
	public GameObject thirdWeight;
	Vector2 doorPos;


	void Start() {
		doorPos = glassDoor.transform.position;
	}

	void OnTriggerEnter(Collider c) {
		if (c.gameObject == thirdWeight) {
			DoorUp ();
		}
	}

	void DoorUp() {
		Debug.Log ("uped");
		Debug.Log (doorPos.y);
		Debug.Log (doorPos);
		while (doorPos.y < 100f) {
			doorPos.y += 1f;
			Debug.Log ("hi");
		}
	}
}
