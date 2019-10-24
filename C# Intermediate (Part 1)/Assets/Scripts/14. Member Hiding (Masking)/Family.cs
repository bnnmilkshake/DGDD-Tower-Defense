using UnityEngine;
using System.Collections;

public class Family : MonoBehaviour {
	void Start() {
		Parent parent = new Parent();
		Child child = new Child();
		SubChild subchild = new SubChild();

		//Parent parent = new Parent();
		//Parent child = new Child();
		//Parent subchild = new SubChild();

		// Despite each parent variable contains a reference to a different class in the inheritance hierarchy, each of them calls the Parent Echo() method.
		parent.Echo();
		child.Echo();
		subchild.Echo();
	}
}