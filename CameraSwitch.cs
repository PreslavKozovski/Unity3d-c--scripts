using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CameraSwitch : MonoBehaviour {

	public Camera cam1;
	public Camera cam2;

	// Update is called once per frame
	public void Start()
	{
		cam1.GetComponent<Camera>().enabled = true;
		cam2.GetComponent<Camera>().enabled = false;
	}



	public void Update()
	{
		if (Input.GetKeyDown ("escape")) {
			cam1.GetComponent<Camera> ().enabled = false;
			cam2.GetComponent<Camera> ().enabled = true;
		}

		//Debug.Log ("");
	}
}
