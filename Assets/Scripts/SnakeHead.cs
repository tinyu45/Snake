using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Collections;
using UnityEngine.UI;
using System.Linq;  //使用last方法

public class SnakeHead : MonoBehaviour {

	public int step; //步长

	public int x;    //速度方向
	public int y;
	public float velocity=0.35f; //速度大小

	private Vector3 headPos; //蛇头位置

	//蛇身节点
	public List<Transform> bodyList=new List<Transform>();
	public GameObject bodyPrefab;
	public Sprite[] bodySprites = new Sprite[2];

	private Transform canvas;


	//int count=0;



	void Awake()
	{
		canvas = GameObject.Find ("Canvas").transform;
	}


	/***
	 *  蛇头移动方法
	 * 
	 *    12
	 * 14  *  21 
	 *    12
	 * **/
	void Move()
	{
		headPos = gameObject.transform.localPosition; //Canvas上位置
		//UGUI canvas 存在缩放值 所以用本地坐标 Image    .position世界坐标（未使用缩放）
		gameObject.transform.localPosition=new Vector3(headPos.x+x, headPos.y+y, headPos.z);
//		bodyList.Last ().localPosition = headPos; //界面显示移动
//		bodyList.Insert(0, bodyList.Last());  
		if(bodyList.Count>0)
		{
			/**
			 * 方法 1：
			 * 
			bodyList[bodyList.Count-1].localPosition=headPos;
			bodyList.Insert(0, bodyList[bodyList.Count-1]);      //加入list 
			bodyList.RemoveAt(bodyList.Count-1);      //清除末尾元素
			*
			**/

			/**
			 *  方法 2： 依次移位
		     *
			 **/
			for (int i = bodyList.Count - 1; i >0; i--) 
			{
				bodyList [i].localPosition = bodyList [i - 1].localPosition;
			}
			bodyList [0].localPosition = headPos;
		}

		//print("步数:"+(++count));
	}




	// Use this for initialization
	void Start () {
		//重复调用 Move 方法   [方法名，延迟时间， 调用间隔]；
		InvokeRepeating("Move", 0, velocity);
		x = step; y = 0; // 初始向右
		gameObject.transform.localRotation=Quaternion.Euler(0,0,- 90);
	}



	// Update is called once per frame

	/***
	 * 蛇头移动方向判断
	 * 
	 * **/
	void Update () {

		//按空格加速
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			CancelInvoke (); //取消重复调用
			InvokeRepeating("Move", 0, velocity-0.2f);
		}

		if (Input.GetKey (KeyCode.W) && y!=-step) 
		{
			//方向归正  = 四元数    旋转（0,0,0）
			gameObject.transform.localRotation=Quaternion.Euler(0,0,0);
			x = 0;y = step;
		}

		if (Input.GetKey (KeyCode.S) && y!=step) 
		{
			gameObject.transform.localRotation=Quaternion.Euler(0,0,180);
			x = 0; y=-step;
		}

		if (Input.GetKey (KeyCode.A) && x!=step) 
		{
			gameObject.transform.localRotation=Quaternion.Euler(0,0,90);
			x = -step; y = 0;
		}

		if (Input.GetKey (KeyCode.D) && x!=-step) 
		{
			gameObject.transform.localRotation=Quaternion.Euler(0,0,-90);
			x = step; y = 0;
		}

		if (Input.GetKeyUp (KeyCode.Space)) 
		{
			CancelInvoke (); //取消重复调用
			InvokeRepeating("Move", 0, velocity);
		}
	}



	/****
	 * 
	 * 蛇身生长 变长
	 * */
	void Grow()
	{
		int index = bodyList.Count % 2 == 0 ? 0 : 1;
		GameObject body = Instantiate (bodyPrefab, new Vector3(900, 500, 0), Quaternion.identity);
		body.GetComponent<Image> ().sprite = bodySprites [index];
		body.transform.SetParent (canvas, false);
		bodyList.Add (body.transform);
	}


	//触发器 函数
	private void OnTriggerEnter2D(Collider2D col)
	{
		//等同于 col.gameobject.tag=="Food"
		if (col.gameObject.CompareTag ("Food")) {
			Destroy (col.gameObject);
			MainUIController.Insatnce.UpdateUI ();
			Grow ();
			FoodMaker.Instance.MakeFood (Random.Range (0, 100) < 20); //生成食物 / 食物+奖励
		} 
		else if(col.gameObject.CompareTag ("Reward"))
		{
			Destroy (col.gameObject); 
			MainUIController.Insatnce.UpdateUI (Random.Range(5, 15)*10);
			Grow ();
			//加分


		}
		else if (col.gameObject.tag == "Body") 
		{
			print ("Die");                 //撞到蛇身死亡
		} 
		else 
		{
			switch (col.gameObject.name)   //碰到边界
			{
			case "top":
				transform.localPosition = new Vector3 (transform.localPosition.x, -transform.localPosition.y+30, 0);
				break;
			case "bottom":
				transform.localPosition = new Vector3 (transform.localPosition.x, -transform.localPosition.y-30, 0);
				break;
			case "left":
				transform.localPosition = new Vector3 (-transform.localPosition.x+(7-1)*30, transform.localPosition.y, 0);
				break;
			case "right":
				transform.localPosition = new Vector3 (-transform.localPosition.x+(7+1)*30, transform.localPosition.y, 0);
				break;
			}
			//print ("撞到边界了");	
		}
	}
}
