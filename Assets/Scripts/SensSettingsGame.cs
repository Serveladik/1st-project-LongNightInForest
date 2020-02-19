using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensSettingsGame : MonoBehaviour {

	public float sensitivityGame=0f;
	public Slider SensSliderGame;
	public Text SensValueTextGame;

	
	void Awake () 
	{
		if(PlayerPrefs.HasKey ("SensValue")==false)
		{
			SensSliderGame.value = 0.4f;
			SensValueTextGame.text = SensSliderGame.value.ToString("#.##");
		}
		else
		{
			SensSliderGame.value =  PlayerPrefs.GetFloat ("SensValue");
		}
	}
	
	
	void Update () 
	{
		//Changing sens values with slider and convert value text to string with  better format (1,00) in game scene
		PlayerPrefs.SetFloat ("SensValue", SensSliderGame.value);
		SensValueTextGame.text = SensSliderGame.value.ToString("#.##");
		


	}
}
