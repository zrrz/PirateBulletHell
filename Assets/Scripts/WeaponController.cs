using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

	static int MAX_WEAPON_RANGE = 15;
	[SerializeField]
	LayerMask layerMask;

	public Weapon[] weapons;

	void Start () {
		
	}
	
	void Update () {
		Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, MAX_WEAPON_RANGE, layerMask);
		if(colliders.Length > 0) {
			Collider2D closestCollider = colliders[0];
			if(colliders.Length > 1) {
				for(int i = 1; i < colliders.Length; i++) {
					if(Vector3.Distance(transform.position, colliders[i].transform.position) < Vector3.Distance(transform.position, closestCollider.transform.position)) {
						closestCollider = colliders[i];
					}
				}
			}
			for(int i = 0; i < weapons.Length; i++) {
				weapons[i].Shoot(closestCollider);
//				print("shooting");
			}
		}
	}
}
