using UnityEngine;
using System.Collections;

public class MoveTank : MonoBehaviour {
	public float rotationSpeed = 1.2f;
	public float moveSpeed = 0.2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Keypad5))
		{
			transform.Translate(Vector3.forward * moveSpeed);
		}
		if (Input.GetKey(KeyCode.Keypad2))
		{
			transform.Translate(-Vector3.forward * moveSpeed/2);
		}
		if (Input.GetKey(KeyCode.Keypad1))
		{
			transform.Rotate(-Vector3.up * rotationSpeed);
		}
		if (Input.GetKey(KeyCode.Keypad3))
		{
			transform.Rotate(Vector3.up * rotationSpeed);
		}
	
	}
}
