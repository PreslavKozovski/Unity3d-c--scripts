using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthControl : MonoBehaviour {
	public RawImage image1;
	public RawImage image2;
	public RawImage image3;

	public static int LIVES = 3;

	void Update()
	{
		switch (LIVES)
		{
		case 3:
			image1.enabled = false;
			image2.enabled = false;
			image3.enabled = true;
			break;
		case 2:
			image1.enabled = false;
			image2.enabled = true;
			image3.enabled = false;
			break;
		case 1:
			image1.enabled = true;
			image2.enabled = false;
			image3.enabled = false;
			break;
		case 0:
			image1.enabled = false;
			image2.enabled = false;
			image3.enabled = false;
			break;
		default:
			image1.enabled = false;
			image2.enabled = false;
			image3.enabled = false;
			break;			
		}
	}

}
