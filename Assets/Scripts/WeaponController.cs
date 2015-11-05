using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

	public static int MAX_WEAPON_RANGE = 15;
	[SerializeField]
	LayerMask targetMask;

	public Weapon[] weaponPrefabs;
	Weapon[] weapons;

	void Start () {
		weapons = new Weapon[weaponPrefabs.Length];
		for(int i = 0; i < weaponPrefabs.Length; i++) {
			weapons[i] = (Weapon)Instantiate(weaponPrefabs[i], transform.position, transform.rotation);
			weapons[i].transform.SetParent(transform);
		}
	}
	
	void Update () {
		FindTarget();
	}

	void FindTarget() {
		Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, MAX_WEAPON_RANGE, targetMask);
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
			}
		}
	}
}
