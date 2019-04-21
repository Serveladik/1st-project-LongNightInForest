using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {


Animator anim2;


	public GameObject zombieStop;
	// Use this for initialization
	void Start()
	{
		anim2=GetComponent<Animator>();
		
	}
	//************************************************************ */


	/*void OnTriggerEnter(Collider other)
	{
		
if(other.gameObject.tag == "gameOVER")
	{
		//anim2.SetBool("GameOver",true);
			Debug.Log("GAMEOVR!!!!!!");
			zombieStop.SetActive (false);

	}
}

*/
	
	// Update is called once per frame
	
}
