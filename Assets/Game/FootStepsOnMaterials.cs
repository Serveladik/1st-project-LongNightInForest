using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class FootStepsOnMaterials : MonoBehaviour {


	public float timeSteps;
	private float timeSteps2;
	private AudioClip HouseClip;
	private AudioClip GrassClip;

public AudioClip[] GrassSound;
public AudioClip[] HouseSound;
private AudioSource source;
private RaycastHit hit;
public bool stepping = false;
private CharacterController controller;
public float StepTimer;
private float StepTimerDown;
public Transform test;
public Transform Player;
	public AudioSource footstepsSounds;
	// Use this for initialization
	void Start () 
	{
		footstepsSounds.volume = 0.4f;
		timeSteps2 = timeSteps;
		source=GetComponent<AudioSource>();
		controller = transform.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	

void Update()
{


	Debug.DrawRay(Player.position,-Player.transform.up,Color.red);

		if(controller.isGrounded)
			{
			if(Input.GetButton("Vertical") || Input.GetButton("Horizontal"))
				{
					Move();
				}
			}	
}

public void Move()
	{
		int index = Random.Range (0, HouseSound.Length);
	    int index2 = Random.Range (0, GrassSound.Length);

		if (timeSteps > 0) 
		{
			timeSteps -= Time.deltaTime;
		}

		if (Physics.Raycast (Player.position, -Player.transform.up, out hit, 90f)) {
		
			if (hit.transform.gameObject.tag == "Terrain") 
			{


				if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.D)) 
				{
					

					if (timeSteps < 0) {
						source.clip = GrassSound[index2];
						source.Play ();
						timeSteps = timeSteps2;
					}

				}
			}

			if (hit.transform.tag == "House") {
				

				if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.D)) {


					if (timeSteps < 0) {
						source.clip = HouseSound[index];
						source.Play ();
						timeSteps = timeSteps2;
					}

				}
			}
			


			
	



		}
	}

}



