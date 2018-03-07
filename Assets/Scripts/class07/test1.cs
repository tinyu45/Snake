using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using pet;

public class test1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PetDog dog = new PetDog ();
		dog.Play ();
		DogBox box = new DogBox ();
		Pet.PetToBox <PetDog, DogBox>(dog, box);

		PetCat cat = new PetCat();
		cat.Play ();
		CatBox box1 = new CatBox ();
		Pet.PetToBox <PetCat, CatBox>(cat, box1);


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
