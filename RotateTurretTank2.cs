using UnityEngine;
using System.Collections;

public class RotateTurretTank2 : BaseRotateTurret {
		
		new public Camera camera;
		public float rotationSpeed = 0.8f;
		// Use this for initialization
		
		
		// Update is called once per frame
		override protected void Update () 
		{
			if (Input.GetKey(KeyCode.Q))
			{
				transform.Rotate(-Vector3.up * rotationSpeed);
			}
			if (Input.GetKey(KeyCode.E))
			{
				transform.Rotate(Vector3.up * rotationSpeed);
			}
			
			
			
			//print ("worldpos" + worldPos);
		}
	}
