using UnityEngine;
using System.Collections;

public class SubChild : Child {
	//This hides the Child version
	new public void Echo() {
		Debug.Log("Sub child version of the Echo() method");
	}
}