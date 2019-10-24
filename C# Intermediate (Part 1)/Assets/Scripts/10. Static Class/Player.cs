using UnityEngine;
using System.Collections;

public static class Player {
	// A static method can be invoked without an object of a class
	// Static methods cannot access non-static member variables
	public static int AddXP(int currentXP, int earnedXP) {
		return currentXP + earnedXP;
	}
}