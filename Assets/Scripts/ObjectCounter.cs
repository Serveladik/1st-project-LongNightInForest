using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ObjectCounter : MonoBehaviour {

	public int Paper;
	public int paperToWin;
	public Animation anim;
	
	
	public AudioSource PaperReadSound;
	public Text NeededPaper;

	public PauseScript psScript;
	public CameraControl cmScript;
	private bool checkTime=true;

	//All piece of papers
	public GameObject Stories1;
	public GameObject Stories2;
	public GameObject Stories3;
	public GameObject Stories4;
	public GameObject Stories5;
	
	public GameObject closePaper;

	public GameObject darkPanel;

void Update()
{
	//Condition when picked up paperasd
	if(checkTime==false)
	{
		//Freezetime=true, camera + cursor disable 
		psScript.PauseTime=0f;
		cmScript.enabled=false;
		Cursor.visible=true;
		
	}

	if(Input.GetKeyDown(KeyCode.F))
	{
		//Condition when close paper screen
		//Freezetime=false, camera + cursor disable 
		psScript.PauseTime=1f;
		checkTime=true;
		cmScript.enabled=true;
		Cursor.visible=false;
		
		Stories1.SetActive(false);
		Stories2.SetActive(false);
		Stories3.SetActive(false);
		Stories4.SetActive(false);
		Stories5.SetActive(false);
		closePaper.SetActive(false);
		darkPanel.SetActive(false);
	}
	

}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Paper")
		{		
			//Condition when you picked up paper
			Paper += 1;
			NeededPaper.text = Paper.ToString();
			PaperReadSound.Play();
			Destroy(other.gameObject);
			checkTime=false;
			closePaper.SetActive(true);
			darkPanel.SetActive(true);
			
			if(Paper==1)
			{
				Stories1.SetActive(true);
			}
			if(Paper==2)
			{
				Stories2.SetActive(true);
			}
			if(Paper==3)
			{
				Stories3.SetActive(true);
			}
			if(Paper==4)
			{
				Stories4.SetActive(true);
			}
			if(Paper==5)
			{
				Stories5.SetActive(true);
			}

			if (Paper == paperToWin) 
			{
				anim.Play ();
			}		
		}
	}
}
