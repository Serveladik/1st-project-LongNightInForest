using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlScript : MonoBehaviour {






public Animation animationC;

Animator animC;
public FPSController Player;




	// Use this for initialization
	void Start () 
	{
	 
	animC =	GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
if(Input.GetKeyDown(KeyCode.W))
		{
			animC.SetBool("X1",true);
		
		}
if(Input.GetKeyUp(KeyCode.W))
		{
			animC.SetBool("X1",false);
		
		}




		
		if(Input.GetKeyDown(KeyCode.LeftShift))
		{
			animC.SetBool("X2",true);
			
		}
		if(Input.GetKeyUp(KeyCode.LeftShift))
		{
			
			animC.SetBool("X2",false);
		}
		
}

		
		
}
//*********************************************************************************** */
		
	
		 
		



	
	
	








