using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections;

public class ToLvl2 : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		if (ArthefactControl.Arthefact == 1) {
			if (other.gameObject.name == "ThirdPersonController") {
				Application.LoadLevel (1);
			}
		}
	}
}
