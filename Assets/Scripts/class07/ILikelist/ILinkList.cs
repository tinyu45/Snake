using UnityEngine;

namespace Idefine{

	public class ILinkList<T>{
		node<T> head;

		public ILinkList(){
			head = new node<T> (default(T));
		}


		public void addAfter(node<T> node, node<T> item){
			if (node.next != null) {
				item.next = node.next;
				node.next = item;
			} else {
				node.next = item;
			}
		}


		public void addBefore(node<T> node, node<T> item){
			if (node.data == null) {
				item.next = node.next;
				node.next = item;
			}
		}

	}




}
