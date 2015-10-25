using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	private float speed = 1.0f;

	[SerializeField]
	float maxRot = 10.0f;

	void Start () {
	
	}
	
	void Update () {
		if(Input.GetButton("Fire1")) {
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			if(hit.collider != null) {
				Vector2 dir = hit.point - new Vector2(transform.position.x, transform.position.y);

				transform.position += transform.up * speed * Time.deltaTime;
				Quaternion lookRot = Quaternion.LookRotation(Vector3.forward, dir);
				transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRot, maxRot);
			}
		}
	}
}