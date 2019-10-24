using UnityEngine;
using System.Collections;

public class ProtectedAccess : MonoBehaviour {
	class ProtectedModifier {
		protected string protectedVariable = "Protected variable and method successfully accessed";

		protected virtual void ProtectedMethod() {
			Debug.Log(protectedVariable);
		}
	}

	class DerivedProtectedModifier : ProtectedModifier {
		public string publicVariable;

		protected override void ProtectedMethod() {
			publicVariable = protectedVariable + " and overwritten";
		}

		public void Concatenate() {
			ProtectedMethod();
			Debug.Log(publicVariable);
		}
	}

	void Start() {
		DerivedProtectedModifier derivedProtectedModifier = new DerivedProtectedModifier(); // Class instance
		derivedProtectedModifier.Concatenate();
	}
}