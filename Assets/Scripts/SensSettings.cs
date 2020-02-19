using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensSettings : MonoBehaviour {

	public float sensitivity2 = 4f;
	public Slider SensSlider;
	public Text SensValueText;
	
	void Start () 
	{
		if(PlayerPrefs.HasKey ("SensValue")==false)
		{
			SensSlider.value = 0.4f;
			SensValueText.text = SensSlider.value.ToString("#.##");
		}
		else
		{
			SensSlider.value =  PlayerPrefs.GetFloat ("SensValue");
		}
		
	}
	
	
	void Update () 
	{
		//Changing sens values with slider and convert value text to string with  better format (1,00) in menu scene
		//sensitivity2 = SensSlider.value;
		PlayerPrefs.SetFloat ("SensValue",SensSlider.value);
		SensValueText.text = SensSlider.value.ToString("#.##");
	}
}
