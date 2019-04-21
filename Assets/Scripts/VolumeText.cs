using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VolumeText : MonoBehaviour {

	public Text VolText;
	public AudioSource volForText;
	private float numb = 0;
	//Volume value in settings as a text
	void Update () 
	{
		numb = volForText.volume;
		VolText.text = numb.ToString ("0.##");
	}
}
