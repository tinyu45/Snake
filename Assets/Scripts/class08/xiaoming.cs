using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace delTest{
	public class xiaoming:MonoBehaviour{

		void Start(){
			if (zhansa.test!= null) {
				zhansa.test(1000);
			}

		}

		public void SayHei(){
			Debug.Log ("张三，早上好！！！");
		}
	}

}
