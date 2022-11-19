using UnityEngine;
using System.Collections;

public class IA : MonoBehaviour {

	private Animator anim;
	private bool atacando = false;
	public GameObject corazon;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (atacando == false) {
			atacando = true;
			StartCoroutine (atacar ());
		}
	}

	IEnumerator atacar() {
		anim.SetBool ("Ataco", true);
		yield return new WaitForSeconds (1);
		anim.SetBool ("Ataco", false);
		corazon.transform.gameObject.SetActive(false);

		yield return new WaitForSeconds (6);
		anim.SetBool ("Ataco", false);
		atacando = false;
	}


}
