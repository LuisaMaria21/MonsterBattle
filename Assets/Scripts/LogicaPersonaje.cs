using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LogicaPersonaje : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();


	
	}
	
	// Update is called once per frame
	void LateUpdate () {
	
	}

	public void Atacar(){

		anim.SetBool("Ataque", true);
	}
}
