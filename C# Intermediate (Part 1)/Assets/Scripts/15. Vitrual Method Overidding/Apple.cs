using UnityEngine;
using System.Collections;

public class Apple : Fruit {
	public Apple() {
		//Debug.Log("1st apple constructor called");
	}

	// These methods are overrides and therefore can override any virtual methods in the parent class.
	public override void Chop() {
		base.Chop();
		Debug.Log("The apple has been chopped");
	}

	public override void Talk() {
		base.Talk();
		Debug.Log("I am an apple");
	}
}