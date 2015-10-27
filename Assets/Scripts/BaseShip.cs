using UnityEngine;
using System.Collections;

public abstract class BaseShip : MonoBehaviour {

	[SerializeField]
	protected float speed = 10.0f;
	
	[SerializeField]
	protected float maxRot = 10.0f;

//	void Start () {
//	
//	}
//	
//	void Update () {
//	
//	}

	protected void MoveTo(Vector2 position) {
		Vector2 dir = position - new Vector2(transform.position.x, transform.position.y);
		
		Quaternion lookRot = Quaternion.LookRotation(Vector3.forward, dir);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRot, maxRot);
		transform.position += transform.up * speed * Time.deltaTime;
	}
}
