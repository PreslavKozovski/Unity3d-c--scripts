using UnityEngine;
using System.Collections;

public class PortalOpen : MonoBehaviour {

	public GameObject child;
	void Update () {
		if (CrystalsControl.currentCrystals == 5) {
			ActivatePortal ();
		}
	}

	private void ActivatePortal()
	{
		child.gameObject.SetActive(true);
	}
}
