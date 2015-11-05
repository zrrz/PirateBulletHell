using UnityEngine;
using System.Collections;

public class Cannoneer : Enemy {

	protected override void Start () {
		base.Start();
	}
	
	void Update () {
		float distance = Vector3.Distance(transform.position, player.transform.position);
		if(distance < range && distance > WeaponController.MAX_WEAPON_RANGE) {
			MoveTo(player.transform.position);
		}
	}
}
