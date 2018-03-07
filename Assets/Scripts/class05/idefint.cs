using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class idefint : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//printStart (9);
		//print(disOfball(200, 3));
		int[] arr=getRandomArr(10, 0,100);
		//int[] arr=new int[10]{6,1,2,7,9,3,4,5,10,8};


		printIntArr (arr);
		arr=quickSort (arr, 0, arr.Length-1);
		printIntArr (arr);
		print (binsearch(arr, 25));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public int[] getRandomArr(int length, int min, int max){
		int[] arr = new int[length];
		for (int i = 0; i < length; i++) {
			arr[i]=Random.Range (min, max);
		}
		return arr;
	}




	public void printIntArr(int[] arr){
		string str = "[";
		for (int i = 0; i < arr.Length; i++) {
			if(i==arr.Length-1) 
				str+=arr[i]+"]";
			else
				str+=arr[i]+",";
		}
		print (str);
	}



	//快速排序
	/**
	 * arr 需排序数组
	 * start 左指针
	 * end  右指针
	 * 
	 * */
	public int[] quickSort(int[] arr, int start, int end){
		int i, j, temp, Base;
		if (start < end) {
			Base = arr [start];

			i = start;
			j = end;
			while (i != j) {

				while (arr [j] >= Base && i < j)
					j--;
				while (arr [i] <= Base && i < j)
					i++;
			
				if (i < j) {
					temp = arr [i];
					arr [i] = arr [j];
					arr [j] = temp;
				}
			}
			arr [start] = arr [i];
			arr [i] = Base;
			return quickSort (quickSort (arr, start, i - 1), i + 1, end);

		} 
		return arr;
	}


	//[1,2,3,4,5,6,7,8,9,10]

	//二分查找
	/**
	 * arr 要查找的数组
	 * item 要查找的元素
	 * */
	public int binsearch(int[] arr, int item){
		int i, j, index;
		i = 0;
		j = arr.Length-1;
		index=(i+j)/2;
		while(arr[index]!= item && i<=j && i>=0){
			if (arr [index] > item) {
				j = index - 1;
			} else {
				i = index + 1;
			}
			index = (i + j) / 2;
		}
		if (item == arr [index])
			return index;
		return -1;
	}

}
