using UnityEngine;
using System.Collections;

public abstract class BaseShip : MonoBehaviour {

	[SerializeField]
	protected float speed = 10.0f;
	
	[SerializeField]
	protected float maxRot = 10.0f;

	protected int health = 3;

	protected void MoveTo(Vector2 position) {
		Vector2 dir = position - new Vector2(transform.position.x, transform.position.y);
		
		Quaternion lookRot = Quaternion.LookRotation(Vector3.forward, dir);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRot, maxRot);
		transform.position += transform.up * speed * Time.deltaTime;
	}

	public virtual void TakeDamage(int damage) {
		health -= damage;
		if(health <= 0)
			Die();
	}

	protected virtual void Die() {
		Destroy(gameObject);
	}
}
