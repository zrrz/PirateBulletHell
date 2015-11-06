using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	public float range = 10.0f;
	public GameObject projectile;
	public int damage = 1;
	public float coolDown = 0.8f;
	public float speed = 1.0f;
	protected float cooldownTimer;

//	void Start () {
//		
//	}
	
	protected virtual void Update () {
		if(cooldownTimer > 0f)
			cooldownTimer -= Time.deltaTime;
	}

	public virtual void Shoot (Collider2D collider) { }
}
