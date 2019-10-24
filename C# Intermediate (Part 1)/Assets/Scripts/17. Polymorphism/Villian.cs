using UnityEngine;
using System.Collections;

public class Villian : MonoBehaviour {
	RogueClass Thief = new RogueClass();

	void Start() {
		Thief.health = 100;
		Thief.strength = 55;
		Thief.intelligence = 95;
		Thief.experience = 1600;
		Thief.stealth = 90;
		Thief.dexterity = 80;

		Thief.Move();
		Thief.ClassUpgrade("lock picking");
		Thief.Chance();
	}
}