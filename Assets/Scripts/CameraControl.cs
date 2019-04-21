using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	public GameObject eyes;

	public float sensitivity;
	float rotX;
	float rotY;

	
	


	
	void Update () 
	{
		//Getting Sensitivity value
		sensitivity = PlayerPrefs.GetFloat ("SensValue");
		//Setting sensitivity values to "Mouse" axis
		rotX = Input.GetAxis("Mouse X") * sensitivity;
		rotY -= Input.GetAxis("Mouse Y") * sensitivity;
		//Setting limitation for camera rotating
		rotY = Mathf.Clamp(rotY, -60f, 60f);
		transform.Rotate(0, rotX, 0);
		//Moving camera in local axis
		eyes.transform.localRotation = Quaternion.Euler(rotY, 0, 0);
	}
}
