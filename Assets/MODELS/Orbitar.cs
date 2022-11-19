using UnityEngine;
using System.Collections;

public class Orbitar : MonoBehaviour {

	public float rotationSpeed;
	public float rotationValue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// transform.Rotate (new Vector3 (0, rotationSpeed, 0) * Time.deltaTime);
		transform.localRotation = Quaternion.Euler(
			transform.localRotation.eulerAngles.x,
			rotationValue,
			transform.localRotation.eulerAngles.z
		);
		rotationValue += rotationSpeed * Time.deltaTime;

	
	}
}
