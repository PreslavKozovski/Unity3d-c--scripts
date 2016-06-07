using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GiveHealth : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "ThirdPersonController") {
			if (HealthControl.LIVES < 3)
				HealthControl.LIVES += 1;
			gameObject.SetActive (false);
		}
	}
}
