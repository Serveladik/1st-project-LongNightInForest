using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioVolume1 : MonoBehaviour {
	public Slider volumeSlider;

	public AudioSource sounds;

	// Use this for initialization
	void Awake()
	{
		//Setting the sounds values to one value
		sounds.volume = 0.7f;
		//Setting the slider value to sounds values to control with it in future
		volumeSlider.value = 0.7f;
		
	}
	
	
	// Update is called once per frame
	void Update () 
	{
		//Setting slider base value to control all the sounds
		PlayerPrefs.SetFloat ("Volume",volumeSlider.value);
		//Changing sounds volume with the slider
		sounds.volume = volumeSlider.value;
		
	}
}
