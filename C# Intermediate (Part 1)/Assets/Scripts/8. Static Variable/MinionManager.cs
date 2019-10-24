//#pragma warning disable 0414

using UnityEngine;
using System.Collections;

public class MinionManager : MonoBehaviour {
	void Start() {
		Minion minion1 = new Minion(); // Object instance
		Minion minion2 = new Minion(); // Object instance
		Minion minion3 = new Minion(); // Object instance

		// One can access a static field by using the class name and the dot operator
		int total = Minion.minionCount;

		print(total);
	}
}