using System;
using UnityEngine;
namespace pet
{
	public class PetDog:Pet,PlayWithPeople
	{
		
		public PetDog ()
		{
			this.price = 120;
			this.age = 6;
			this.name = "小黑";
			this.kemu = "犬科";
		}


		public void Play(){
			Debug.Log("狗在和人玩");
		}


	}
}

