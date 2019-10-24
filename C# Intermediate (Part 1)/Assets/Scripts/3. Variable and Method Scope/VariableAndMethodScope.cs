using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableAndMethodScope : MonoBehaviour {
	string scope1 = "start";

	void Start() {
		print(scope1); // Prints global variable value
		CheckScope();
	}

	void CheckScope() {
		string scope1 = "1"; // Declared as a local variable with the same name as global variable
		print(scope1); // Prints local variable value which overrides global value

		scope1 = "2"; // Declared as a local variable with the same name as previous local variable
		print(scope1); // Prints local variable value which overrides all global and local values as it is treated as global if declared without var keyword
	}
}