﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodMaker : MonoBehaviour {

	public int xLimit = 21;
	public int yLimit = 11;
	public int xoffset = 7; //21-7
	public GameObject foodPrefab;
	public Sprite[] foodSprites;
	public Transform foodHolder;

	/**单例模式**/
	private static FoodMaker _instance; 
	public static FoodMaker Instance
	{
		get
		{
			return _instance;
		}
	}

	void Awake()
	{
		//类初始化时
		_instance=this;
	}

	/**单例模式**/


	// Use this for initialization
	void Start () {
		foodHolder = GameObject.Find ("FoodHolder").transform;
		MakeFood ();
	}


	/****
	 * 生成食物的方法
	 * **/
	public void MakeFood()
	{
		int index = Random.Range (0, foodSprites.Length);
		GameObject food = Instantiate (foodPrefab); //实例化食物
		food.transform.SetParent(foodHolder, false); //阻止Unity放大物体
		int posX=Random.Range(-xLimit+xoffset, xLimit);
		int posY = Random.Range (-yLimit, yLimit);
		food.GetComponent<Image> ().sprite = foodSprites [index];
		food.transform.localPosition = new Vector3 (posX * 30, posY * 30, 0);
	}

}
