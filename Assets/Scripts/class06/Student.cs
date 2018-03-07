using System;
using classTest;
using UnityEngine;

namespace Idefined
{
	public class Student
	{
		public string name;
		public Score[] scores;

		public void setData(string name, Score[] scores){
			this.name = name;
			this.scores = scores;
		}


		public void getResult(){
			string str = "成绩信息如下：\n";
			for (int i = 0; i < scores.Length; i++) {
				str += (scores [i].getscore() + "\n");
			}
			Debug.LogFormat ("我是{0},{1}", name, str);
		}
	}
}

