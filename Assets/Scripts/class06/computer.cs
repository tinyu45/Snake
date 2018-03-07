using System;
using classTest;
using UnityEngine;
namespace Idefined
{
	public class computer
	{
		public string brand;
		public float price;
		public int memory;
		public int disk;
		public string CPU;
		public string GPU;
		public mouse mouse;
		public keyboard keyboard;
		public computer ()
		{
			Debug.LogFormat ("我是一台{0}牌计算机，可以用来工作、玩游戏和聊天！", brand);
		}


		public void PlayGames(){
			Debug.Log ("游戏中...");
		}

		public void work(){
			Debug.Log ("工作中...");
		}

		public void chat(){
			Debug.Log ("聊天中...");
		}
	}
}

