using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GiveCrystals : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "ThirdPersonController") {
			CrystalsControl.currentCrystals += 1;
			gameObject.SetActive (false);
		}
	}
}
