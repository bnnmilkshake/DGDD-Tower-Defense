using UnityEngine;
using System.Collections;

public class OverloadedConstructor : MonoBehaviour {
	void Start() {
		Circle circle = new Circle(45); // Object instantiation
		//Circle circle = new Circle(32.5f); // Object instantiation
		Debug.Log("Area = " + circle.Area().ToString());
		Debug.Log("Circumference = " + circle.Circumference().ToString());
	}

	class Circle {
		private int radius;
		private float diameter;

		public Circle() { // Default constructor
			radius = 0;
			diameter = 0;
			Debug.Log("Radius = " + radius + "\n" + "Diameter > " + diameter);
		}

		public Circle(float initialDiameter) { // Overloaded constructor
			diameter = initialDiameter;
			Debug.Log("Diameter = " + diameter);
		}

		public Circle(int initialRadius) : this() { // Overloaded constructor
			radius = initialRadius;
			Debug.Log("Radius = " + radius);
		}

		public float Area() {
			return Mathf.PI * radius * radius;
		}

		public float Circumference() {
			return Mathf.PI * diameter;
		}
	}
}