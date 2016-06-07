using UnityEngine;
using System.Collections;

public class GiveArtefact : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "ThirdPersonController") {
			ArthefactControl.Arthefact += 1;
			gameObject.SetActive (false);
		}
	}
}
