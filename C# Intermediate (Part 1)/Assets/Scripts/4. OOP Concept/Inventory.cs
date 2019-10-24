using UnityEngine;
using System.Collections;

public class Inventory {
	// Properties
	public int ID {get; set;}
	public string InventoryName {get; set;}

	public Inventory(string Name, int ID) { // Constructor
		InventoryName = Name;
		this.ID = ID;
	}

	public Item FindAndReturnItem(int itemID) { // Method
		Item returnItem = new Item() {
			ID = itemID,
			Name = "Steel Gaunlet"
		};

		return returnItem;
	}
}