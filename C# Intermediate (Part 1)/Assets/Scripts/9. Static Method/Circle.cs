using UnityEngine;
using System.Collections;

public class Circle {
	private int radius;
	public static int diameter = 0;

	public Circle() { // Default constructor
		radius = 0;
		diameter = 2 * radius;
	}

	public Circle(int initialRadius) { // Overloaded constructor
		radius = initialRadius;
		diameter = 2 * radius;
	}

	public float Area() {
		return Mathf.PI * radius * radius;
	}

	public static float Circumference() {
		return Mathf.PI * diameter;
	}
}