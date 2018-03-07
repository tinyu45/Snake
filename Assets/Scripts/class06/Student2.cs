using System;
using classTest;
using UnityEngine;
namespace Idefined
{
	public class Student2
	{
		private string sno;
		private string name;
		private Score2[] scores;

		public string Sno{
			get{ return this.sno;}
			set{ this.sno = value;}
		}


		public string Name{
			get{ return this.name;}
			set{ this.name = value;}
		}


		public Score2[] Scores{
			get{return this.scores;}
			set{this.scores = value;}
		}

		public void PrintMes(){
			string str = "成绩信息如下：\n";
			for (int i = 0; i < scores.Length; i++) {
				str += (scores [i].getscore() + "\n");
			}
			Debug.LogFormat ("我是{0},{1}", name, str);
		}
			
	}
}

