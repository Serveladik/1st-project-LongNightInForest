using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGameOver : MonoBehaviour {

	public float timing;
	public bool isPaused;
	


	void OnTriggerEnter(Collider other){
if(other.gameObject.tag == "kill")
	{


Time.timeScale=timing;

	isPaused=true;


if (isPaused == true)
{
	timing=0;
}
else if (isPaused == false)
{
	timing = 1;
}

	}}
}
