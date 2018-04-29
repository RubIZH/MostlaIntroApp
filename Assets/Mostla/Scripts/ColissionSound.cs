using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColissionSound : MonoBehaviour {


	public AudioClip hit;

	// Use this for initialization
	void Start () {

		GetComponent<AudioSource> ().playOnAwake = false;
		GetComponent<AudioSource> ().clip = hit;
	}

	void OnCollisionEnter(Collision col){

		if (col.gameObject.tag == "Floor") {

			GetComponent<AudioSource> ().Play ();
		}


	}
		

}
