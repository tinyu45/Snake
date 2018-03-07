using UnityEngine;

namespace Idefine{
	public class node<T>{
		public T data;
		public node<T> next = null;


		public node(T t){
			this.data = t;
		}
	}


}

