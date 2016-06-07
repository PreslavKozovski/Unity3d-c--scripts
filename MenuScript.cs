using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {


	public Canvas quitMenu;
	public Canvas mainMenu;
	public Button startText;
	public Button exitText;
	public CameraSwitch cam;
	public Text gameOver;

	// Use this for initialization
	void Start () {
	
		quitMenu = quitMenu.GetComponent <Canvas> ();
		mainMenu = mainMenu.GetComponent <Canvas> ();
		startText = startText.GetComponent <Button> ();
		exitText = exitText.GetComponent <Button> ();
		quitMenu.enabled = false;
		mainMenu.enabled = false;
		//CameraSwitch.cam2.enabled = false;

	}



	public void ExitPress()
	{
		quitMenu.enabled = true;
		mainMenu.enabled = false;
	}

	public void NoPress()
	{
		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
		cam.cam1.GetComponent<Camera>().enabled = true;
		cam.cam2.GetComponent<Camera>().enabled = false;

	}

	public void StartLevel()
	{
		ArthefactControl.Arthefact = 0;
		CrystalsControl.currentCrystals = 0;
		Application.LoadLevel ("test");
		HealthControl.LIVES = 3;
	}

	public void GameOver()
	{
		
			mainMenu.enabled = true;
			gameOver.gameObject.SetActive(true);
	
	}

	public void ExitGame()
	{
		
		Application.Quit();
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("escape"))
		{
			//Debug.Log ("presed");
			mainMenu.enabled = true;

		}

		if (HealthControl.LIVES == 0) {
			gameOver.gameObject.SetActive (true);
			mainMenu.enabled = true;
			cam.cam1.GetComponent<Camera>().enabled = false;
			cam.cam2.GetComponent<Camera>().enabled = true;
		}

	}
}
