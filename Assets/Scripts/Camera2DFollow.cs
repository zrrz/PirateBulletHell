using System;
using UnityEngine;

public class Camera2DFollow : MonoBehaviour {
    public Transform target;
    public float damping = 1;

	public Vector2 cameraBoundsX, cameraBoundsY;
	
    private float m_OffsetZ;
    private Vector3 m_CurrentVelocity;

    private void Start() {
        m_OffsetZ = (transform.position - target.position).z;
        transform.parent = null;
    }

    private void Update() {
		transform.position = target.position + Vector3.forward*m_OffsetZ;

		Vector3 clampedPosition = transform.position;
		clampedPosition.x = Mathf.Clamp(transform.position.x, cameraBoundsX.x, cameraBoundsX.y);
		clampedPosition.y = Mathf.Clamp(transform.position.y, cameraBoundsY.x, cameraBoundsY.y);
		transform.position = clampedPosition;
	}
}