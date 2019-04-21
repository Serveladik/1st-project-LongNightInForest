using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour {

	public bool IsSecMenu=false;
	public GameObject Resume;
	public GameObject Settings;
	public GameObject Quit;

	public GameObject SettingsMenu2;
	public GameObject Slider;
	public GameObject Back;



	// Use this for initialization
	void Awake()
	{
		SettingsMenu2.SetActive (false);
		Back.SetActive(false);
		Slider.SetActive(false);
	}

	public void SetVolume()
	{
		Resume.SetActive (false);
		Settings.SetActive (false);
		Quit.SetActive (false);

		SettingsMenu2.SetActive (true);
		Slider.SetActive(true);
		Back.SetActive(true);
		IsSecMenu = true;
	}
}
