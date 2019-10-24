using UnityEngine;
using System.Collections;

public class PublicAccess : MonoBehaviour {
	class PublicModifier {
		public string publicVariable = "Public variable and method successfully accessed";

		public void PublicMethod() {
			Debug.Log(publicVariable);
		}
	}

	void Start() {
		PublicModifier publicModifier = new PublicModifier(); // Class instance
		publicModifier.PublicMethod();
	}
}