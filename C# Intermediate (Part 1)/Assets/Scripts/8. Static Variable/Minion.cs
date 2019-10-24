//#pragma warning disable 0414

using UnityEngine;
using System.Collections;

public class Minion {
	// Static variables or fields are shared across all instances of a class
	public static int minionCount = 0;

	public Minion() {
		// Increment static field to track how many objects of this class have been instantiated
		minionCount++;
	}
}