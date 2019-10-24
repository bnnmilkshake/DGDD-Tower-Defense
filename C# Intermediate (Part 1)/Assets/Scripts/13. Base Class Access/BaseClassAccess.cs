using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClassAccess : MonoBehaviour {
	class NonPlayerCharacter { // Base or super class for NPC
		public string npcName;
		public bool npcHasWeapon;

		// Base class constructor
		public NonPlayerCharacter(string npc, bool weapon) {
			npcName = npc;
			npcHasWeapon = weapon;
			Debug.Log("Base class constructor initialized");
		}

		public virtual void IsWalking() { // Class method
			Debug.Log(npcName + " is patrolling.");
		}
	}

	class Guard : NonPlayerCharacter {
		// Derived class constructor
		public Guard(string npc, bool weapon) : base(npc, weapon) { // Call the original constructor and npc name
			Debug.Log("Derived class constructor initialized with inheritance from base constructor");
		}

		public override void IsWalking() {
			if(npcHasWeapon == true) {
				Debug.Log(npcName + " is armed and dangerous.");
			} else {
				Debug.Log(npcName + " is not armed but still dangerous.");
			}
		}
	}

	void Start() {
		NonPlayerCharacter securityGuard = new NonPlayerCharacter("Security Guard", true);
		securityGuard.IsWalking();
		Guard sentryGuard = new Guard("Sentry Guard", false);
		sentryGuard.IsWalking();
	}
}