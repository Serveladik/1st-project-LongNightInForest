using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTriggerEnterSounds : MonoBehaviour {



	public Slider sliderForHouse;
	public AudioSource SoundsInHouse;
	public GameObject rainInHouse;
	public AudioLowPassFilter LowPass;




	//Activating LowPass effect and disabling Rain when player come into the house	
	void OnTriggerEnter( Collider other )
	{
		if (other.gameObject.tag == "House") 
		{
			LowPass.enabled=true;
			rainInHouse.SetActive (false);
		}
	}
	//Disabling LowPass effect and enabling Rain when player come out of the house
		void OnTriggerExit( Collider other )
		{
			if (other.gameObject.tag == "House")
			{
				rainInHouse.SetActive (true);
				LowPass.enabled=false;
			}
		}
}
