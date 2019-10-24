using UnityEngine;
using System.Collections;

public class MagicianClass : CharacterClass {
	public int mana;

	public void Heal() {
		Debug.Log("Health regained");
	}

	public void CastSpell() {
		Debug.Log("Spell casted");
	}
}