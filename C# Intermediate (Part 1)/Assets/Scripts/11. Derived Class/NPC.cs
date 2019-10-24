using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour {
	void Update() {
		transform.Rotate(0, 100 * Time.deltaTime, 0);
	}
}
