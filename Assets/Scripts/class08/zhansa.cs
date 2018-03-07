using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zhansa : MonoBehaviour {

	public delegate void Say (int score);
	public static Say test;
	private int score;
	// Use this for initialization


	public void zhansaSay(int score){
		this.score = score;
		print ("总得分："+score);
	}




	void Start () {
		test += zhansaSay;
//		print ("zhansa C# script");
//		test += zhansaSay;
//		if(test!=null){
//			test ();
//		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
