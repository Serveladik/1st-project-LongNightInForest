using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class EnemyMoveTowards : MonoBehaviour {
	//Перемещение
	public Transform Points; //цель
	public AudioSource zombieSound;
	public Transform Player;
	public Transform myTransform;
	  //переменная для хранения ссылки на свойство transform
	public float speed;
	// Места телепортации
	public Animator anim;
	private string teg;	// Тег места перемещения
	private int rand;	// Рандомное число для случайного выбора тега
		Animator anim2;
	// Таймер
	public float coolDown;       //время между телепортациями
	private float attackTimer;    //таймер
	bool flag = false;
	
	NavMeshAgent agent;
	void OnTriggerEnter( Collider other )
		{
			if(other.gameObject.tag == "kill")
			{
				
				agent.enabled=true;
				agent.speed=35;
				zombieSound.Play ();
				anim2.SetBool("Collide", true);
				
	
				Debug.Log("LongSoundTrue");
				flag=true;
			}

		}

void OnTriggerExit( Collider other )
{
	if(other.gameObject.tag == "kill")
		{
			agent.enabled=false;
			attackTimer=6;
			agent.speed=0;
			anim2.SetBool("Collide", false);
			
			Debug.Log("LongSongFalse");
			flag=false;
		}
}
	void Awake(){
		//ссылка на transform чтоб сократить время обращения его в теле скрипта
		anim2 = GetComponent<Animator>();
		myTransform = transform;
		agent = GetComponent<NavMeshAgent>();
		attackTimer=0;
	}
	
	// Use this for initialization

void Start()
{
	agent = GetComponent<NavMeshAgent>();
}
void MoveEnemy()
{
	agent.SetDestination(Player.position);
}

	

	void Update () 
	{
		//Debug.Log(attackTimer);
		if(flag==true)
			{
				
				MoveEnemy();
			}
		else
			{
		if(flag==false)
			{
				//выдерживаем паузу
				if(attackTimer > 0)
					attackTimer -= Time.deltaTime;
				//на всякий случай обнуляем результат
				if(attackTimer < 0)
					attackTimer = 0;
				//если пауза выдержана то телепортируемся
				if(attackTimer == 0)
				{
				
				rand = Random.Range(1, 9);
					switch(rand)
					{
					case 1:
						teg = "Point1";
						break;
					case 2:
						teg = "Point2";
						break;
					case 3:
						teg = "Point3";
						break;
					case 4:
						teg = "Point4";
						break;
					case 5:
						teg = "Point5";
						break;
					case 6:
						teg = "Point6";
						break;
					case 7:
						teg = "Point7";
						break;
					case 8:
						teg = "Point8";
						break;
					}
					//ищем по тегу Point
					GameObject go = GameObject.FindGameObjectWithTag(teg);//.transform
					//поставить на него прицел
					Points = go.transform;
				Teleport ();
				}
			}
		}		
	}

	



	
	
	
	
	void Teleport () 
	{
		// Разворачиваемся
		//myTransform.rotation = Quaternion.Slerp(myTransform.rotation,Quaternion.LookRotation(Points.position - myTransform.position),10000);
		// Телепортируемся
		myTransform.position = Points.position;
		
		attackTimer = coolDown;
	}



	

 void OnTriggerStay( Collider other )
	{
		
		float step = speed*Time.deltaTime;
	if(other.gameObject.tag == "Victim")
	{
    transform.position = Vector3.MoveTowards(transform.position,Player.position,step);

	}
	}
}