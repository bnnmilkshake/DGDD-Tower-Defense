using UnityEngine;
using System.Collections;

public class Fighter : MonoBehaviour {

	CharacterClass Knight = new CharacterClass();
	CharacterClass Barbarian = new CharacterClass();

	void Start() {
		Knight.health = 100;
		Knight.strength = 75;
		Knight.intelligence = 60;
		Knight.experience = 750;

		Knight.Move();
		Knight.ClassUpgrade("knight");

		Barbarian.health = 100;
		Barbarian.strength = 90;
		Barbarian.intelligence = 40;
		Barbarian.experience = 475;

		Barbarian.ClassUpgrade("barbarian");
	}
}