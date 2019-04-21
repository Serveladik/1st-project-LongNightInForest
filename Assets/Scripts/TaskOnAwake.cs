using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskOnAwake : MonoBehaviour {
public GameObject TaskText;
public Animation TaskAnim;
	// Use this for initialization
	void Awake()
	{
		//Animation of task 
		TaskText.SetActive(true);
		TaskAnim.Play("TaskAnim");
	}
	

}
