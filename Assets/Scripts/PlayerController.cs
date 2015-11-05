using UnityEngine;
using System.Collections;

public class PlayerController : BaseShip {

//	[SerializeField]
//	private float speed = 1.0f;
//
//	[SerializeField]
//	float maxRot = 10.0f;

	static PlayerController s_player;

	public static PlayerController player {
		get {
			return s_player;
		}
	}

	void Awake() {
		s_player = this;
	}

//	void Start () {
//	
//	}
	
	void Update () {
		if(Input.GetButton("Fire1")) {
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			if(hit.collider != null) {
				MoveTo(hit.point);
			}
		}
	}

	public override void TakeDamage (int damage)
	{
		base.TakeDamage (damage);
		GUIManager.SetPlayerHealth(health);
	}
}