using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensSettingsGame : MonoBehaviour {

	public float sensitivityGame=0f;
	public Slider SensSliderGame;
	public Text SensValueTextGame;

	
	void Start () 
	{
		//Getting Sens values from menu to game scene
		SensSliderGame.value = PlayerPrefs.GetFloat ("SensValue");
		SensValueTextGame.text = PlayerPrefs.GetFloat ("SensValue").ToString("#.##");
	}
	
	
	void Update () 
	{
		//Changing sens values with slider and convert value text to string with  better format (1,00) in game scene
		sensitivityGame=SensSliderGame.value;
		SensValueTextGame.text = SensSliderGame.value.ToString("#.##");
		PlayerPrefs.SetFloat ("SensValue", sensitivityGame);


	}
}
