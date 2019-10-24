using UnityEngine;
using System.Collections;

public class PrivateAccess : MonoBehaviour {
	class PrivateModifier {
		private string privateVariable = "Private variable and method are inaccessible externally";

		private void PrivateMethod() {
			Debug.Log(privateVariable);
		}

		public void Echo() {
			PrivateMethod();
        }
	}

	void Start() {
		PrivateModifier privateModifier = new PrivateModifier(); // Class instance
		//privateModifier.PrivateMethod(); // Inaccessible due to private access modifiers
		privateModifier.Echo();
	}
}