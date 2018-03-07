using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class arrtest : MonoBehaviour {


	void Start () {
		string str = "";
		//int[] arr = new int[10];
		int[] arr={1,3,45,667,878,990};

		for (int i = 0; i < arr.Length; i++) {
			//arr [i] = Random.Range (0, 99);
			str += (arr [i] + ",");
		}
		print (str);

		//遍历查找
		print(binSearch(arr,10, 0, arr.Length));

	}
		
	public static int binSearch(int[] arr,int num, int start, int end){
		if (start >= end)
			return -1;
		else {
			int center = start+(end-start)/2;

			if (arr [center] == num)
				return center;
			else if (arr [center] > num)
				return binSearch (arr, num, 0, center - 1);
			else
				return binSearch (arr, num, center+1, arr.Length);
		}
	}


	// Update is called once per frame
	void Update () {
		
	}



}
