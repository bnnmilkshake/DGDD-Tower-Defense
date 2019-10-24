using UnityEngine;
using System.Collections;

public class RogueClass : CharacterClass {
	public int stealth;
	public int dexterity;

	public override void Move() { // Override method in parent class
		Debug.Log("Sneaking mode");
	}

	public void Chance() {
		float luck = Random.Range(0, 10);
		if (luck <= 5)
			Debug.Log("No luck");
		else
			Debug.Log("Lucky day");
	}
}