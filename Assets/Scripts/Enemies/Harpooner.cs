using UnityEngine;
using System.Collections;

public class Harpooner : Enemy {

	float grabRange = 15.0f;

	public float rotateSpeed = 15.0f;

	protected override void Start () {
		base.Start();
	}
	
	void Update () {
		if(Vector3.Distance(transform.position, player.transform.position) < range) {
			if(Vector3.Distance(transform.position, player.transform.position) < grabRange) {
				//HACK GHETTO PLZ FIX

				Vector3 prevPos = transform.position;
				Quaternion prevRot = transform.rotation;
				transform.RotateAround(player.transform.position, Vector3.forward, rotateSpeed * Time.deltaTime);
				Vector3 newPos = transform.position;
				transform.position = prevPos;
				transform.rotation = prevRot;
				MoveTo(newPos);
						
//				Quaternion rotation = Quaternion.LookRotation(player.transform.position - transform.position, transform.TransformDirection(Vector3.up));
//				transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);
			} else {
				MoveTo(player.transform.position);
			}
		}
	}
}
