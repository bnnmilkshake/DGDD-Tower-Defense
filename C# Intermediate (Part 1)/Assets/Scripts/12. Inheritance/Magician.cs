using UnityEngine;
using System.Collections;

public class Magician : MonoBehaviour {
	MagicianClass Mage = new MagicianClass();

	void Start() {
		Mage.health = 100;
		Mage.mana = 100;
		Mage.strength = 50;
		Mage.intelligence = 95;
		Mage.experience = 1200;

		Mage.Move();
		Mage.ClassUpgrade("mage");
		Mage.Heal();
		Mage.CastSpell();
	}
}