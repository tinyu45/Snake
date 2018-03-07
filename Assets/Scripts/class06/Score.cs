using System;
using UnityEngine;
namespace classTest
{
	public class Score
	{
		public readonly string course;
		public float grade;

		public Score ()
		{
		}

		public Score(string course, float grade){
			this.course = course;
			this.grade = grade;
		}

		public string getscore(){
			return course + ":\t" + grade;
		}
	
	}
}

