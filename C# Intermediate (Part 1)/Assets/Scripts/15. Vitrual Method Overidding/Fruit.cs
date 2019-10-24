using UnityEngine;
using System.Collections;

public class Fruit {
	public Fruit() {
		//Debug.Log("1st fruit constructor called");
	}

	// Methods are virtual and thus can be overriden in child classes
	public virtual void Chop() {
		Debug.Log("The fruit has been chopped");
	}

	public virtual void Talk() {
		Debug.Log("I am a fruit");
	}
}