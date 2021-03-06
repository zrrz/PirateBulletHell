﻿using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	Transform target;
	Vector3 startPosition;
	float time = 0;

	[SerializeField]
	GameObject explosionPrefab;

	float speed;

	int damage;

	void Update () {
		if(target != null) {
			time += Time.deltaTime * speed;
			transform.position = Vector3.Lerp(startPosition, target.position, time);
			if(time > 1f) {
				Instantiate(explosionPrefab, transform.position, Quaternion.identity);
				transform.position = Vector3.one * 1000f;
				gameObject.SetActive(false);
				target.GetComponent<BaseShip>().TakeDamage(damage);
			}
		} else {
			transform.position = Vector3.one * 1000f;
			gameObject.SetActive(false);
		}
	}

	public void SetTarget(Transform setTarget, float setSpeed, int setDamage) {
		time = 0f;
		startPosition = transform.position;
		target = setTarget;
		speed = setSpeed;
		damage = setDamage;
	}

	public void SetTarget(Vector3 setTarget, float setSpeed, int setDamage) {
		time = 0f;
		startPosition = transform.position;
		//target = setTarget;
		speed = setSpeed;
		damage = setDamage;
	}
}
