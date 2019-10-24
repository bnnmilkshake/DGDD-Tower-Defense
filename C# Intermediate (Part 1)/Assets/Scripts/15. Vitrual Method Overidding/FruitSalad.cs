using UnityEngine;
using System.Collections;

public class FruitSalad : MonoBehaviour {
	void Start() {
		Apple newApple = new Apple();

		// Methods of the Apple version override the fruit version
		// both are called since the Apple version call the Fruit version with the "base" keyword
		newApple.Chop();
		newApple.Talk();

		Fruit newFruit = new Apple();

		// Overriding is also useful in a polymorphic situation
		// Since the methods of the Fruit class are virtual and the methods of the Apple class are override, the methods of the Apple version are used when upcast an Apple into a Fruit
		newFruit.Chop();
		newFruit.Talk();
	}
}