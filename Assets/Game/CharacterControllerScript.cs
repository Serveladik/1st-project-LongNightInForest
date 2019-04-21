using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class CharacterControllerScript : MonoBehaviour {

public AudioClip[] clips;




public Animation animation;
CharacterController controller;
Animator anim;
public FPSController Player;
AudioSource source;



	// Use this for initialization
	void Start () 
	{
	 controller=GetComponent<CharacterController>();
	anim =	GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
if(Input.GetKeyDown(KeyCode.W))
		{
			anim.SetBool("Run",true);
}

if(Input.GetKeyUp(KeyCode.W))
		{
			anim.SetBool("Run",false);
		
		}




		
		if(Input.GetKeyDown(KeyCode.LeftShift))
		{
			anim.SetBool("RunX2",true);
			
		}
		if(Input.GetKeyUp(KeyCode.LeftShift))
		{
			
			anim.SetBool("RunX2",false);
		}
		
}

		
		

//*********************************************************************************** */
		
	
		 
		


}
	
	
	



