using System;
using UnityEngine;

namespace pet
{
	public class PetCat:Pet,PlayWithPeople
	{
		public PetCat ()
		{
		}

		public void Play(){
			Debug.Log ("猫在和人玩");
		}
	}
}

