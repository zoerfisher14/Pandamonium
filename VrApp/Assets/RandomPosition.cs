using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GiveRandomPos(){
		System.Random r = new System.Random();
		float x = (float) r.NextDouble()*10;
		float y = (float) r.NextDouble()*10;
		float z = (float) r.NextDouble()*10;
		x *= (float) Math.Pow (-1, r.Next (3));
		y *= (float) Math.Pow (-1, r.Next (3));
		z *= (float) Math.Pow (-1, r.Next (3));
		transform.position = new Vector3(x,y,z);
	}
}
