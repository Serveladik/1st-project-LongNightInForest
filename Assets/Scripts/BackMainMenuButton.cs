using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMainMenuButton : MonoBehaviour {
	public bool IsBack=false;

	public GameObject NewGame;
	public GameObject Settings;
	public GameObject Exit;

	public GameObject VolumeMenu;
	public GameObject Slider;
	public GameObject Back;
	
	public void BackButtonPress()
	{
		//When we`re pressing the "Back" button, we are disabling "Settings menu" and enabling the "Main menu"
		
		
			NewGame.SetActive (true);
			Settings.SetActive (true);
			Exit.SetActive (true);

			VolumeMenu.SetActive (false);
			Slider.SetActive (false);
			Exit.SetActive (false);
		
	}
}
