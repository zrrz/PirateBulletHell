using UnityEngine;
using System.Collections;

public class Cannon : Weapon {

//	void Start () {
//		
//	}

	protected override void Update () {
		base.Update ();
	}

	public override void Shoot (Collider2D collider) {
		if(cooldownTimer <= 0f) {
			GameObject obj = StaticPool.GetObj(projectile, transform.position, Quaternion.identity);
			obj.GetComponent<Projectile>().SetTarget(collider.transform, speed, damage);
			cooldownTimer = coolDown;
		}
	}
}
