using System;
using UnityEngine;

namespace Idefined
{
	public class Account
	{
		string id;
		string name;
		string address;
		float jin_e=0;  //金额
		float min_e;  //最少余额

		public Account(string id, string name, string address, float min_e){
			this.id = id;
			this.name = name;
			this.address = address;
			this.min_e = min_e;
		}

		public void save(float money){
			float old_e = jin_e;
			jin_e += money;
			Debug.LogFormat ("账户原有金额：{0}元\n本次存款操作存入金额为:{1}元\n存入后余额为{2}元",old_e,money,jin_e);
		}

		public void getMoney(float money){
			if (jin_e - money <= min_e) {
				Debug.LogFormat ("余额不足，至少保留{0}元", min_e);
				return;
			}else{
				jin_e -= money;
				Debug.LogFormat ("本次取款：{0}元\n账户余额为：{1}元",money, jin_e);
			}
		}

		public void search(){
			Debug.LogFormat ("当前账户{0}余额为：{1}元",id,jin_e);
		}




	}
}

