using System;
using UnityEngine;

namespace pet
{
	public abstract class PetBox
	{
		protected string size;
		protected string name;

		public string Size{
			get{return this.size;}
		}

		public string Name{
			get{return this.name;}
		}




	}



	public class DogBox:PetBox{

		public DogBox(){
			this.name="狗笼";
			this.size = "中型";
			Debug.Log ("成功创建一个狗笼");
		}
	}


	public class CatBox:PetBox{

		public CatBox(){
			this.name="猫笼";
			this.size = "小型";
			Debug.Log ("成功创建一个猫笼");
		}
	}



}

