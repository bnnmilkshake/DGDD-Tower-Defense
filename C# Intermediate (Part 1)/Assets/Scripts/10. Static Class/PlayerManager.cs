using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
	void Start() {
		// Access a static method by using the class name and the dot operator
		int total = Player.AddXP(250, 120);

		Debug.Log(total);
	}
}