using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grasswalking : MonoBehaviour {
public AudioSource audio;
	// Use this for initialization
	void Start () {
		audio=GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	
	void OnTriggerEnter(Collider other)
	{
	if (other.gameObject.tag == "House")
        	{
				audio.volume=1f;
	}
}

void OnTriggerExit(Collider other)
	{
	if (other.gameObject.tag == "House")
        	{
				audio.volume=0f;
	}
}

}
