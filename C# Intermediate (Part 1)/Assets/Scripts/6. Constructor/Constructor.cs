using UnityEngine;
using System.Collections;

public class Constructor : MonoBehaviour {
	class Character {
		public string FirstName {get; set;}
		public string LastName {get; set;}
		public string Type {get; set;}
		public int Health {get; set;}
		public int Mana {get; set;}
		public int Strength {get; set;}
		public int Intelligence {get; set;}
		public int Experience {get; set;}
		public int ClassLevel {get; set;}
		
		public int LevelUp(int Experience) {
			ClassLevel = Mathf.FloorToInt(Experience / 500); // Round down to the nearest integer
			return ClassLevel;
		}

		public Character() { // Default constructor

		}

		public Character(string firstName, string lastName, int health, int mana, int strength, int intelligence, int experience) {
			FirstName = firstName;
			LastName = lastName;
			Health = health;
			Mana = mana;
			Strength = strength;
			Intelligence = intelligence;
			Experience = experience;
			//ClassLevel = classlevel;
		}
	}

	void Start() {
		Character Fighter = new Character(); // Object instance
		Fighter.FirstName = "Alan"; // Initialization
		Fighter.LastName = "Drake";
		Fighter.Health = 100;
		Fighter.Mana = 0;
		Fighter.Strength = 85;
		Fighter.Intelligence = 60;
		Fighter.Experience = 750;

		Debug.Log("Fighter " + Fighter.FirstName + " " + Fighter.LastName + " has strength and intelligence of " + Fighter.Strength + " and " + Fighter.Intelligence);
		Debug.Log("Fighter current class is " + Fighter.LevelUp(Fighter.Experience));

		Character Mage = new Character { // Object instance with initialization
			FirstName = "Seth",
			LastName = "Goodwill",
			Health = 100,
			Mana = 100,
			Strength = 50,
			Intelligence = 95,
			Experience = 1200,
		};

		Debug.Log("Mage " + Mage.FirstName + " " + Mage.LastName + " has strength and intelligence of " + Mage.Strength + " and " + Mage.Intelligence);
		Debug.Log("Mage current class is " + Mage.LevelUp(Mage.Experience));

		Character Elf = new Character("Elyon", "Carmys", 100, 50, 70, 85, 1600);
		Debug.Log("Elf " + Elf.FirstName + " " + Elf.LastName + " has strength and intelligence of " + Elf.Strength + " and " + Elf.Intelligence);
		Debug.Log("Elf current class is " + Elf.LevelUp(Elf.Experience));
	}
}