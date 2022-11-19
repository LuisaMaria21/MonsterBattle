using UnityEngine;
using System.Collections;

public class ShowMonster : MonoBehaviour {

	public GameObject player;
	public GameObject enemy;

	// Use this for initialization
	private void OnTriggerEnter(Collider other)
	{
		player.transform.gameObject.SetActive(true);
		enemy.transform.gameObject.SetActive(true);
	}
}