using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ArthefactControl : MonoBehaviour {

	Text txt;
	public static int Arthefact = 0;

	void Start () {
		txt = gameObject.GetComponent<Text> ();
		txt.text = "Arthefact: " + Arthefact + "/1";
	}

	void Update () {
		txt.text = "Arthefact: " + Arthefact + "/1";
	}
}
