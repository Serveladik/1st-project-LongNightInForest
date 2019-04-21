using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseScript : MonoBehaviour {
	public bool firstMenu=false;
	public float PauseTime;
	public bool IsPaused=false;
	public GameObject menu;
	public CameraControl mouseLookDisable;
	public SettingsMenu SettingsMenu3;
	public GameOverSound gmOver;
	public GameObject pausePanel;
	// Use this for initialization
	void Start () 
	{
		
		PauseTime = 1f;
	}

	// Update is called once per frame
	void Update () 
	{
		Time.timeScale = PauseTime;

		if(Input.GetKeyDown(KeyCode.Escape) && IsPaused==false)
			{
				IsPaused = true;
				Cursor.visible = true;
				mouseLookDisable.enabled = false;
				firstMenu = true;

				
			}
		else if(Input.GetKeyDown(KeyCode.Escape) && IsPaused==true && SettingsMenu3.IsSecMenu==false)
				{
					IsPaused = false;
					Cursor.visible = false;
					mouseLookDisable.enabled = true;
					firstMenu = false;

				}
		if (IsPaused == true ) 
		{
			PauseTime = 0;
			menu.SetActive(true);
			mouseLookDisable.enabled = false;
			firstMenu = true;
			pausePanel.SetActive(true);

		} 
		else if (IsPaused == false && gmOver.gameover==true ) 
		{
			PauseTime = 1;

			mouseLookDisable.enabled = false;

		}
		else if (IsPaused == false ) 
		{
			PauseTime = 1;
			menu.SetActive(false);
			mouseLookDisable.enabled = true;
			firstMenu = false;
			pausePanel.SetActive(false);
		}



	}
	public void ResumeButton(bool pause)
	{
		IsPaused = pause;
		Cursor.visible = false;
		mouseLookDisable.enabled = true;
	}
}