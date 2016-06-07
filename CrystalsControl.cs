using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CrystalsControl : MonoBehaviour {

	Text txt;
	public static int currentCrystals = 0;

	void Start () {
		txt = gameObject.GetComponent<Text> ();
		txt.text = "Crystals: " + currentCrystals + "/5";
	}

	void Update () {
		txt.text = "Crystals: " + currentCrystals + "/5";
	}
}
