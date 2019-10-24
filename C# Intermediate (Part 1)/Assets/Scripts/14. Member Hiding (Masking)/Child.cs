using UnityEngine;
using System.Collections;

public class Child : Parent {
	// This hides the Parent version
	new public void Echo() {
		Debug.Log("Child version of the Echo() method");
	}
}