using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/***
 * 
 * 
 * */

public class CycleTest : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		string str1 = "";
		string str2 = "";
		char c='a';
		while (c <= 'z') 
		{
			print (c);
			str1 += (char)(c - 32);
			str2 += c;
			str2 += (char)(c - 32);
			c++;
		}
		print (str1);
		print (str2);
	} 








	// Update is called once per frame
	void Update () {
		
	}
}
