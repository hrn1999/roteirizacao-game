using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassAnimation : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other){
		if (other.CompareTag("Player")){
			anim.SetTrigger("trigger");
		}

	}
}
