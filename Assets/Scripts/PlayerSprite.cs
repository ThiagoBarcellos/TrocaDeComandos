using UnityEngine;

public sealed class PlayerSprite : MonoBehaviour
{
	public PlayerController controller;
	public SpriteRenderer spriteRenderer;
	public Animator playerAnimator;

	public string onAirAnimationParam = "OnAir";
	public string movingAnimationParam = "Moving";
	public string duckingAnimationParam = "Duck";
	public string stunAnimationParam = "Hit";

	private void Update()
	{
		float horizontalVelocity = controller.playerRigidbody.velocity.x;
		bool isMoving = Mathf.Abs( horizontalVelocity ) > 0.001f;

		if( isMoving )
			spriteRenderer.flipX = horizontalVelocity < 0.0f;

		playerAnimator.SetBool( movingAnimationParam, isMoving );
		playerAnimator.SetBool( onAirAnimationParam, !controller.isGrounded );
		playerAnimator.SetBool( duckingAnimationParam, controller.isDucking );
		playerAnimator.SetBool( stunAnimationParam, controller.isStunned );
	}
}
