using UnityEngine;

public sealed class FollowTarget : MonoBehaviour
{
	public Transform target;
	public float followSpeed = 9999.0f;

	public Vector3 lerp = Vector3.one;

	private Vector3 initialPosition;

	private void Awake()
	{
		initialPosition = transform.position;
	}

	private void LateUpdate()
	{
		float maxDelta = followSpeed * Time.deltaTime;
		Vector3 position = transform.position;

		position.x = Mathf.MoveTowards( position.x, target.position.x, maxDelta );
		position.y = Mathf.MoveTowards( position.y, target.position.y, maxDelta );
		position.z = Mathf.MoveTowards( position.z, target.position.z, maxDelta );

		position.x = Mathf.Lerp( initialPosition.x, position.x, lerp.x );
		position.y = Mathf.Lerp( initialPosition.y, position.y, lerp.y );
		position.z = Mathf.Lerp( initialPosition.z, position.z, lerp.z );

		transform.position = position;
	}
}
