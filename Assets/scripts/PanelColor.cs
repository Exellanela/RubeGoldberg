using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//not working for some reason
public class PanelColor : MonoBehaviour {

	public GameObject weight;
	public GameObject panel;
	Material panelMatColor;
	public Material red;
	public Material green;


	void Start() {
		panelMatColor = panel.GetComponent<Material> ();
		panelMatColor = red;
	}

	void OnTriggerEnter(Collider c) {
		if (c.gameObject == weight) {
			//Debug.Log ("HI");
			panelMatColor = green;
		}
	}
}
