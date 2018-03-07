using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Idefined;
using classTest;

public class main : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//GetComputer ();  //电脑类测试
		//GetPhone();   //手机类测试
		//Get2DPoint();  //二维点测试
		//GetStudent();   //学生类测试

		//GetStudent2 ();  //学生类2测试
		AccountTest();

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void GetComputer(){
		computer c = new computer ();
		c.brand = "";  //品牌
		c.price=2; //价格
		c.memory=1;
		c.disk = 2;
		c.CPU = "";
		c.GPU="";

		c.mouse = new mouse ("35","red",1);
		c.keyboard = new keyboard ("34", "blank", 23);

		c.chat ();
		c.work ();
		c.PlayGames ();
	}

	void GetPhone(){
		MobilePhone MP = new MobilePhone ("","",1,5);
		MP.PrintPhoneConf ();
		MP.Call ();
		MP.SendMessage ();
		MP.chat ();
	}


	void Get2DPoint(){
		D2Point d1 = new D2Point (1,2);
		D2Point d2 = new D2Point (3, 5);

		Debug.LogFormat ("点{0}与点{1}之间的距离为：{2}", d1.ToString(),d2.ToString(), D2Point.GetDis(d1,d2));
		Debug.LogFormat ("点{0}与点{1}的和为：{2}", d1.ToString(), d2.ToString(), (d1 + d2).ToString());
	}


	void GetStudent(){
		Student stu = new Student ();
		Score[] arr = new Score[3];
		arr [0] = new Score ("语文",89);
		arr [1] = new Score ("数学",73);
		arr [2] = new Score ("英语",80);
		stu.setData ("小明", arr);
		stu.getResult();
	}



	void GetStudent2(){
		Score2[] arr = new Score2[3];
		arr [0] = new Score2 ("语文");
		arr [0].Grade = 89;
		arr [1] = new Score2 ("数学");
		arr [1].Grade = 73;
		arr [2] = new Score2 ("英语");
		arr [2].Grade = 80;

		Student2 stu2 = new Student2 ();
		stu2.Sno="11022478";
		stu2.Name="张三";
		stu2.Scores = arr;

		stu2.PrintMes ();
	}

	void AccountTest(){
		Account a1 = new Account ("62483959469090705","张飒","北京东城区人民路135号",15);
		a1.search();

		a1.save (500);
		a1.save (13.5f);

		a1.getMoney (300);

		a1.getMoney (1000);
		a1.search();
	}
}
