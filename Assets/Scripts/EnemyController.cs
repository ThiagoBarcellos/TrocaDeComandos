using UnityEngine;

public sealed class EnemyController : MonoBehaviour
{
	public Vector2 moveVelocity;

	public float moveDistance;
	public bool invertedMovement = false;
	
	private Vector3 initialPosition;

	private void Awake()
	{
		initialPosition = transform.position;
	}

	private void Update()
	{
		if( invertedMovement )
			transform.position -= ( Vector3 ) ( moveVelocity * Time.deltaTime );
		else
			transform.position += ( Vector3 ) ( moveVelocity * Time.deltaTime );

		Vector2 moveDirection = Vector3.Normalize( moveVelocity );
		float positionProjection = Vector3.Dot( moveDirection, transform.position - initialPosition );

		bool movingFurtherThanMovementBounds = ( positionProjection < 0.0f ) == invertedMovement;
		bool tooDistantFromInitialPosition = Mathf.Abs( positionProjection ) > moveDistance;
		if( tooDistantFromInitialPosition && movingFurtherThanMovementBounds )
			invertedMovement = !invertedMovement;
	}

	private void OnDrawGizmos()
	{
		if( !Application.isPlaying )
			initialPosition = transform.position;

		if( moveVelocity.magnitude > Mathf.Epsilon )
		{
			var rotation = Quaternion.FromToRotation( Vector3.right, moveVelocity );
			Gizmos.matrix = Matrix4x4.TRS( initialPosition, rotation, Vector3.one );
			Gizmos.DrawWireCube( Vector3.zero, new Vector3( moveDistance * 2.0f, 1.0f, 1.0f ) );
		}
	}
}
