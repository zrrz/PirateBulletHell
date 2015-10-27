using UnityEngine;
using System.Collections;

public class Bomber : Enemy {

	public GameObject explosionPrefab;

	protected override void Start () {
		base.Start();
	}
	
	void Update () {
		if(Vector3.Distance(transform.position, player.transform.position) < range) {
			MoveTo(player.transform.position);
			if(Vector3.Distance(player.transform.position, transform.position) < 1.0f) {
//				StaticPool.GetObj(explosionPrefab, transform.position, Quaternion.identity);
				Instantiate(explosionPrefab, transform.position, Quaternion.identity);
				Destroy(gameObject);
			}
		}
	}
}
