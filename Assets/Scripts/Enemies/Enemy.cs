using UnityEngine;
using System.Collections;

public abstract class Enemy : BaseShip {

	protected PlayerController player;

	[SerializeField]
	protected float range = 35.0f;

	protected virtual void Start () {
		player = PlayerController.player;
	}
	
	void Update () {
	
	}
}
