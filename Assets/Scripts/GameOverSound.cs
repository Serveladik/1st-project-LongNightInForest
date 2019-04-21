using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameOverSound : MonoBehaviour {
	public SphereCollider playerCollider;
	public AudioSource zombieSound;

	public Animator zombieAnimator;
	public EnemyMoveTowards zombieScript;

	public FPSController playerScript;
	public AudioSource playerSteps;
	public Animator playerAnimator;
	public CameraControl cameraScript;
	public bool gameover = false;
	public Rigidbody playerRig;
	public Animation animText;
	//public Animation HandsAnim;
	public AnimationClip[] animC;
	public AudioSource zombieLongCollider;




	//public GameObject light;
	public GameObject Linterna1;
	public GameObject Linterna2;
	public GameObject Linterna3;
	public GameObject GameOverText;
	public SphereCollider zombieColider;



	IEnumerator OnTriggerEnter( Collider other )
	{
		//Conditions when characted dead
		if(other.gameObject.tag == "kill")
		{
			//Character`s actions when he die
			Linterna2.SetActive (false);
			Linterna3.SetActive (false);
			Linterna1.GetComponent<Rigidbody> ().useGravity = true;
			Linterna1.GetComponent<Rigidbody> ().AddForce(transform.forward*200f) ;
			//Crutch
			zombieLongCollider.enabled=false;
			//Zombie`s eatting sounds
			zombieSound.Play ();
			//Disable zombie actions
			zombieScript.enabled = false;
			zombieAnimator.enabled=false;
			//Disable player actions
			playerScript.enabled = false;
			playerSteps.enabled = false;
			playerAnimator.enabled = false;
			cameraScript.enabled = false;
			gameover = true;
			playerCollider.enabled = true;
			playerRig.useGravity = true;
			GameOverText.SetActive (true);

			//Animated text "Game over" with red screen
			animText.Play ();
			

			//Latency before New game
			yield return new WaitForSeconds(5) ;
			SceneManager.LoadScene ("MenuScene");
		   	Cursor.visible=true;



		}

	}
	// Use this for initialization

	
	// Update is called once per frame

}
