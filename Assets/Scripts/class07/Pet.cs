using UnityEngine;
using pet;

public abstract class Pet{
	public string name;
	protected int age;
	protected float price;
	protected string kemu;

	public int Age{
		get{ return this.age;}
	}

	public float Price{
		get{ return this.price;}
	}

	public string Kemu{
		get{ return this.kemu;}
	}


	public static void PetToBox<P, B>(P p, B b) where P:Pet where B:PetBox{
		Debug.Log (p.name + "开始进入了" + b.Name);
	}

}
