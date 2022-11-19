using UnityEngine;
using System.Collections;

public class Defensa : MonoBehaviour {

	public GameObject player;
	private Animator anim;
	private bool defendiendo = false;

	// Use this for initialization
	void Start () {
		anim = player.GetComponent<Animator> ();
	}

	// Update is called once per frame
	private void OnTriggerEnter(Collider other){
		Debug.Log ("Defendiendo..");
		StartCoroutine(defender ());
	}

	IEnumerator defender(){
		if (defendiendo == false) {
			anim.SetBool ("Defensa", true);
			defendiendo = true;
			yield return new WaitForSeconds (1);
			anim.SetBool ("Defensa", false);
			defendiendo = false;
		}
	}


}
