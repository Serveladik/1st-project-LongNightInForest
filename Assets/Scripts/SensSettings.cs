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
		//Setting value in menu to slider and text value of slider in menu scene
		SensSlider.value = sensitivity2;
		SensValueText.text = SensSlider.value.ToString("#.##");
	}
	
	
	void Update () 
	{
		//Changing sens values with slider and convert value text to string with  better format (1,00) in menu scene
		sensitivity2 = SensSlider.value;
		PlayerPrefs.SetFloat ("SensValue",sensitivity2);
		SensValueText.text = SensSlider.value.ToString("#.##");
	}
}
