using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	public Transform lookAtTarget;
	public Transform moveToTarget;

	void Update() {
		if (lookAtTarget != null) {
			transform.LookAt (lookAtTarget.position);
		}
			
		if (moveToTarget != null) {
			Vector3 moveDir = moveToTarget.position - transform.position;

			if (moveDir.magnitude > 1f) {
				moveDir = moveDir.normalized;
			}

			transform.position += moveDir * Time.deltaTime * 10f;
		}
	}
}
