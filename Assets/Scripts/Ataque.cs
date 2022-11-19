using UnityEngine;
using System.Collections;

public class Ataque : MonoBehaviour {

	public GameObject player;
	private Animator anim;
	private bool atacando = false;
	//public Material materailrojo;

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
			//materailrojo = GetComponents<Renderer>().material;
			yield return new WaitForSeconds (1);
			//this.transform.gameObject.SetActive(true);

			anim.SetBool ("Ataque", false);

			atacando = false;

		}
	}


}
