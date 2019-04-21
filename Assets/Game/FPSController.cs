using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FPSController : MonoBehaviour
{

	public float speed = 10f;
	public float RunSpeed=40f;

	public CharacterController player;



public float Volume = 0.7f;



	float moveFB;
	float moveLR;

	float rotX;
	float rotY;
	public float vertVelocity;
	public float jump = 30f;
	float jumpTimes;
	float shift;


	// Use this for initialization







	// Update is called once per frame
	void Update()
	{



		Physics.gravity = new Vector3(0, -70.0F, 0);


		moveFB = Input.GetAxis("Vertical") * speed;
		moveLR = Input.GetAxis("Horizontal") * speed;



		Vector3 movement = new Vector3(moveLR, vertVelocity, moveFB);



		movement = transform.rotation * movement;
		player.Move(movement * Time.deltaTime);

		

if(Input.GetKey(KeyCode.LeftShift))
{
	speed=RunSpeed;
}
else{
	speed=26f;
}

		if (player.isGrounded == true)
		{ 
			jumpTimes = 0;
		}
		if (jumpTimes < 1)
		{
			if (Input.GetButtonDown("Jump"))
			{
				vertVelocity += jump;
				jumpTimes += 1;
			}

		}
	}
	void FixedUpdate()
	{
		if (player.isGrounded == false)
		{
			vertVelocity += Physics.gravity.y * Time.deltaTime;
		}
		else
		{
			vertVelocity = 0f;
		}
	}


	  }
			 
	  

