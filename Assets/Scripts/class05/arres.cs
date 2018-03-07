using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arres : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int[,] arres = new int[3, 4]{ { 1, 2, 3, 0 }, { 4, 5, 6, 0 }, { 7, 8, 9, 0 } };  //规则数组

		int[][] arres2 = new int[3][] { 
			new int[]{ 1, 2, 3, 4 }, 
			new int[]{ 5, 6, 7, 8 }, 
			new int[]{ 9, 10, 11, 12 }
		};

		printArres (arres);


		printArres (Transpose (arres));



	}
	// Update is called once per frame
	void Update () {
		
	}


	public int[,] Transpose(int[,] arres){
		//int[][] a = new int[3][];
		int[,] NewArres = new int[arres.GetLength(1),arres.GetLength(0)];
		for (int i = 0; i < arres.GetLength (0); i++) {
			for (int j = 0; j < arres.GetLength (1); j++) {
				NewArres [j, i] = arres [i, j];
			}
		}
		return NewArres;
	}


	public void  printArres(int[,] arres){
		for (int i = 0; i < arres.GetLength (0); i++) {
			string str="";
			for (int j = 0; j < arres.GetLength (1); j++) {
				str += (arres [i, j] + ",");
			}
			print (str);
		}
	}
}
