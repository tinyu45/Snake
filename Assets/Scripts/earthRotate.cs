using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earthRotate : MonoBehaviour {

	public GameObject centerpoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (0,1,0);
		this.transform.RotateAround (centerpoint.transform.position, new Vector3(0,1,0), 0.15f);
	}
}
