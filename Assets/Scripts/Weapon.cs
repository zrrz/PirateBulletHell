using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	public float range = 10.0f;
	public GameObject projectile;
	public int damage = 1;
	public float coolDown = 0.8f;
	public float speed = 1.0f;
	float cooldownTimer;

	void Start () {
		
	}
	
	void Update () {
		if(cooldownTimer > 0f)
			cooldownTimer -= Time.deltaTime;
	}

	public void Shoot(Collider2D collider) {
		Debug.Log("Shoot " + collider.gameObject.name);
		if(cooldownTimer <= 0f) {
			GameObject obj = StaticPool.GetObj(projectile, transform.position, Quaternion.identity);
			obj.GetComponent<Projectile>().SetTarget(collider.transform, speed, damage);
			cooldownTimer = coolDown;
		}
	}
}
