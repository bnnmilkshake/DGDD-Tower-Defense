using UnityEngine;
using System.Collections;

public class CombinedInventoryManager : MonoBehaviour {
	void Start() {
		Inventory newInventory = new Inventory("Inventory 1", 99);
		Item myItem = newInventory.FindAndReturnItem(99);

		Debug.Log("Item Retrieved: " + myItem.Name);
	}

	public class Inventory {
		public int ID {
			get; set;
		}
		public string InventoryName {
			get; set;
		}

		public Inventory(string Name, int ID) { // Constructor
			InventoryName = Name;
			this.ID = ID;
		}

		public Item FindAndReturnItem(int itemID) {
			Item returnItem = new Item() {
				ID = itemID,
				Name = "Steel Gaunlet"
			};
			return returnItem;
		}
	}

	public class Item {
		public int ID {
			get; set;
		}
		public string Name {
			get; set;
		}
	}
}