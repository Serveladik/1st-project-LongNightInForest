using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeFromMenu2 : MonoBehaviour {

	// Use this for initialization
	public GameObject Resume;
	public GameObject Settings;
	public GameObject Quit;

	public GameObject SettingsMenu;
	public GameObject Slider;
	public GameObject Back;

	public SettingsMenu 	 stMenu;
	
	public PauseScript 	     psScript;
	// Update is called once per frame
	void Update () 
	{
		//Conditions for escaping from menu with "Escape" button
		if (Input.GetKeyDown (KeyCode.Escape) && stMenu.IsSecMenu == true) 
		{
			Resume.SetActive (true);
			Settings.SetActive (true);
			Quit.SetActive (true);

			SettingsMenu.SetActive (false);
			Slider.SetActive (false);
			Back.SetActive (false);
			psScript.firstMenu = true;
		} 
		else 
		{
			stMenu.IsSecMenu = false;
			psScript.firstMenu = false;
		}




	}
}





				

				

				

				
