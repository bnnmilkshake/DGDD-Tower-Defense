using UnityEngine;
using System.Collections;

public class SubClass : MonoBehaviour {
	void Start() {
		BaseClass newClass = new BaseClass(); // Class instance

		// The specific Add method called will depend on the arguments passed in
		Debug.Log(newClass.Add(1, 2));
		Debug.Log(newClass.Add("Try", "Again"));
		//newClass.Add(1, "Two");
	}
}