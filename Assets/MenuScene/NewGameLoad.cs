using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewGameLoad : MonoBehaviour {
	//public Slider sliderNewGame;
	//public AudioSource adSrcNewGame;
	
	public GameObject MusicManager;
	
	public void LoadByName(string SceneName)
	{
		//adSrcNewGame.volume = PlayerPrefs.GetFloat ("Volume");
		//sliderNewGame.value = PlayerPrefs.GetFloat ("VolumeSlider");
		SceneManager.LoadScene (SceneName);
		Cursor.visible = false;
		
	}
	

}
