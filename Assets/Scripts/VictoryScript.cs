using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScript : MonoBehaviour 
{

	public GameObject VictoryPanel;
	public Animation VictoryAnim;
	public CameraControl CameraControl;
	public FPSController fpsControlScript;
	public CharacterControllerScript chScript;
	public FootStepsOnMaterials ftScript;
	public EnemyMoveTowards enmyScript;
	public Animator anHands;

	//All victory actions
	IEnumerator OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "kill") 
		{
			VictoryPanel.SetActive (true);
			VictoryAnim.Play ();

			Debug.Log("WIN");
			CameraControl.enabled = false;
			fpsControlScript.enabled = false;
			chScript.enabled = false;
			ftScript.enabled = false;
			enmyScript.enabled = false;
			anHands.enabled = false;
			yield return new WaitForSeconds (3);
			SceneManager.LoadScene ("MenuScene");
		}
	}
}
