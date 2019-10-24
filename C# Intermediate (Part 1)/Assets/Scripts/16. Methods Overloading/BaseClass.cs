using UnityEngine;
using System.Collections;

public class BaseClass {
	//The first Add method has a signature of "Add(int, int)" which must be unique
	public int Add(int number1, int number2) {
		return number1 + number2;
	}

	//The second Add method has a sugnature of "Add(stringing, stringing)" which must be unique
	public string Add(string string1, string string2) {
		return string1 + " " + string2;
	}
}