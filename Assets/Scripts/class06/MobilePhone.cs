using UnityEngine;
namespace Idefined
{
	public class MobilePhone
	{
		string brand;
		float price;
		string color;
		float screen;

		public MobilePhone (string brand, string color, float screen, float price)
		{
			this.price = price;
			this.color = color;
			this.brand = brand;
			this.screen = screen;
		}

		//只读
		public string Brand{
			get{ return this.brand;}
		}


		//只读
		public string Color{
			get{ return this.color;}
		}


		//只读
		public float Price{
			get{ return this.price;}
		}


		public float Screen{
			get{ return this.screen;}
		}


		public void PrintPhoneConf(){
			Debug.LogFormat ("" +
				"品牌：\t{0}\n" +
				"颜色：\t{1}\n" +
				"屏幕：\t{2}\n" +
				"售价：\t{3}",brand,color,screen,price);
		}

		public void Call(){
			Debug.Log ("通话中...");
		}

		public void SendMessage(){
			Debug.Log ("短信发送中...");
		}

		public void chat(){
			Debug.Log ("您的好友已上线...");
		}


	}
}

