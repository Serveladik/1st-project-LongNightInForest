using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour {
	

	public GameObject Resume;
	public GameObject Settings;
	public GameObject Quit;

	public GameObject SettingsMenu;
	public GameObject Slider;
	public GameObject Back;


	

	public void BackButtonPress(bool BackCheck)
	{
		//When we`re pressing the "Back" button, we are disabling "Settings" menu and enabling the "Pause" menu
			Resume.SetActive (true);
			Settings.SetActive (true);
			Quit.SetActive (true);

			SettingsMenu.SetActive (false);
			Slider.SetActive (false);
			Back.SetActive (false);
			


	}
}
