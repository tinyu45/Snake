using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jisuan : MonoBehaviour {

	// Use this for initialization
	void Start () {
		getCountball ();
		getCountball2 ();
		getFruitsBill ();
	}

	public static void getCountball()
	{
		int Basketball = 5;
		int Tabletennis = 10;
		int Football = 34;
		int Badminton = 786;
		int Volleyball = 237;

		print("排球和篮球的总数为：" + (Basketball + Volleyball));
		print("所有球的总数为：" + (Basketball + Tabletennis + Football + Badminton + Volleyball));
	}

	public static void getCountball2()
	{
		int BboxCount = 10;
		int VboxCount = 20;
		int BboxSize = 10;
		int VboxSize = 12;
		print("10箱篮球和20箱足球的总和为：" + (BboxCount*BboxSize+VboxCount*VboxSize));
	}

	public static void getFruitsBill()
	{
		float applePrice = 3.2f;
		float orangePrice = 1.5f;
		float mangoPrice = 5.6f;
		float watermelonPrice = 9.3f;
		float grapePrice = 10f;

		print("购买16斤橘子和二十公斤芒果,需支付：" + (16 * orangePrice + 20 * 2 * mangoPrice) + "元");
		print("\n各种水果各购买20斤，账单如下：");
		print("品名\t\t数量\t价格\t金额");
		print("1.苹果\t\t20\t"+applePrice+"\t"+applePrice*20);
		print("2.橘子\t\t20\t" + orangePrice + "\t" + orangePrice * 20);
		print("3.芒果\t\t20\t" + mangoPrice + "\t" + mangoPrice * 20);
		print("4.西瓜\t\t20\t" + watermelonPrice + "\t" + watermelonPrice * 20);
		print("5.葡萄\t\t20\t" + grapePrice + "\t" + grapePrice * 20);
		print("费用总计：" + (applePrice + orangePrice + mangoPrice + watermelonPrice + grapePrice) * 20+"元");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
