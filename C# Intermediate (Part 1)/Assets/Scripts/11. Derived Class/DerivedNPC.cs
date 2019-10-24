using UnityEngine;
using System.Collections;

public class DerivedNPC : NPC {
	private bool state = true;

	void Start() {
		StartCoroutine("ColorSwitch");
	}

	IEnumerator ColorSwitch() {
		while(true) {
			yield return new WaitForSeconds(1.5f); // Delay for 1.5 seconds

			if(state) {
				GetComponent<Renderer>().material.color = new Color(1, 0, 0, 1); // Red color
				state = false;
			} else {
				GetComponent<Renderer>().material.color = new Color(0, 0, 1, 1); // Blue color
				state = true;
			}
		}
	}
}