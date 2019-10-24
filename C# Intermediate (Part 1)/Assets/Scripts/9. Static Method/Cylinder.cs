using UnityEngine;
using System.Collections;

public class Cylinder : MonoBehaviour {
	private float height = 2;

	void Start() {
		Circle circle = new Circle(5);
		float volume = circle.Area() * height; // Access instanced method
		Debug.Log(volume);

		//Debug.Log(Circle.diameter); // Access static data
		//Debug.Log(Circle.Circumference()); // Access static method

		float surfaceArea = Circle.Circumference() * height + 2 * circle.Area(); // Access static method
		Debug.Log(surfaceArea);
	}
}