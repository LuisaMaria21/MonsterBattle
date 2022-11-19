using UnityEngine;
using System.Collections;

public class Ataque2 : MonoBehaviour {

	public GameObject player;
	private Animator anim;
	private bool atacando = false;

	// Use this for initialization
	void Start () {
		anim = player.GetComponent<Animator> ();
	}

	// Update is called once per frame
	private void OnTriggerEnter(Collider other){
		Debug.Log ("Atacando..");
		StartCoroutine(atacar ());
	}

	IEnumerator atacar(){
		if (atacando == false) {
			anim.SetBool ("Ataque", true);
			atacando = true;
			yield return new WaitForSeconds (1);
			anim.SetBool ("Ataque", false);
			atacando = false;
		}
	}


}

