using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	public float range = 10.0f;
	public GameObject projectile;
	public float damage = 2.0f;
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
		if(cooldownTimer <= 0f) {
			print("shooting");
			GameObject obj = (GameObject)Instantiate(projectile, transform.position, Quaternion.identity);
			obj.GetComponent<Projectile>().SetTarget(collider.transform, speed);
			cooldownTimer = coolDown;
		}
	}
}
