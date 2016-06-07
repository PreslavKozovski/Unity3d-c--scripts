using UnityEngine;
using System.Collections;

public class TankDestroy : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "PA_ArchfireTank") {
			gameObject.SetActive (false);
			other.gameObject.SetActive (false);
		}
	}
}
