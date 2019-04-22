
using UnityEngine;
using System.Collections;

public class VictimSlender : MonoBehaviour {
	private float distance;
	public GameObject target; // Слендер
	//public GameObject PlayerCamera; // Для наложения эффекта на камеру

	

	public AudioSource zombieRoar;
	public AudioClip[] zombieSounds;

	// Для поиска скрипта мыши и его отключения
	// Use this for initialization
	
	void Start () {
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		//вводим переменную distance и вычисляем расстояние между игроком и противником
		distance = Vector3.Distance(target.transform.position, transform.position);
		//вычисляем еденичный вектор направления к цели
		Vector3 dir = (target.transform.position - transform.position).normalized;
		//вычисляем нахождение цели в поле зрения (значение 0 или отриц - сзади. значение 1 или положительное - впереди) значение меняется от 1 до -1
		float direction = Vector3.Dot(dir,transform.forward);
		//если дистанция меньше максимальной то можем нанести урон

		if(distance < 5 && direction > 0){
			
		EnemyMoveTowards sl = (EnemyMoveTowards)target.GetComponent("Slender");
		//eh.AddjustCurrentHealth(-10); 
		
		//PlayerCamera.GetComponent<SepiaToneEffect>().enabled = true;
		Time.timeScale = 0;
		
		
		}
	}
	
	

}