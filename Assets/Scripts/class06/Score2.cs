using System;

namespace classTest
{
	public class Score2
	{
		private string course;
		private float grade;

		public Score2(string course){
			this.course = course;
		}

		public string Course{
			get{ return this.course;}
		}

		public float Grade{
			get{ return this.grade;}
			set{ this.grade = value;}
		}

		public string getscore(){
			return course + ":\t" + grade;
		}

	}
}



