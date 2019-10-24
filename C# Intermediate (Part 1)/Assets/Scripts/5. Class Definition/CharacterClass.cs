using UnityEngine;
using System.Collections;

public class CharacterClass {
	// Member variables
	public string firstName;
	public string lastName;
	public string gender;
	public int health;
	public int strength;
	public int intelligence;
	public int experience;
	private int classLevel;

	// Member functions
	public virtual void Move() {
		// Define character movement behaviors
		Debug.Log("Walking mode");
	}

	public void ClassUpgrade(string type) {
		// Define character class level
		classLevel = Mathf.FloorToInt(experience / 500); // Round down to the nearest integer
		Debug.Log("Class " + classLevel + " " + type);
	}
}