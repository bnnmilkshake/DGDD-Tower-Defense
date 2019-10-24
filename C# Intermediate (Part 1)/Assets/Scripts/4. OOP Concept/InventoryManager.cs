using UnityEngine;
using System.Collections;

public class InventoryManager : MonoBehaviour {
	void Start() {
		Inventory newInventory = new Inventory("Inventory 1", 99);
		Item myItem = newInventory.FindAndReturnItem(99);

		Debug.Log("Item Retrieved: " + myItem.Name);
	}
}