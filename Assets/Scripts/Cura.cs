using UnityEngine;
using System.Collections;

public class Cura : MonoBehaviour {

	public GameObject player;
	private Animator anim;
	private bool curando = false;
	public GameObject corazon;

	// Use this for initialization
	void Start () {
		anim = player.GetComponent<Animator> ();
	}

	// Update is called once per frame
	private void OnTriggerEnter(Collider other){
		Debug.Log ("Curando..");
		StartCoroutine(curar ());

	}

	IEnumerator curar(){
		if (curando == false) {
			anim.SetBool ("Cura", true);
			curando = true;
			corazon.transform.gameObject.SetActive(true);

			yield return new WaitForSeconds (1);
			anim.SetBool ("Cura", false);
			curando = false;
			this.transform.gameObject.SetActive(false);

		}
	}


}
