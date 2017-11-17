using UnityEngine;

public sealed class PlayerJump : MonoBehaviour
{
    public PlayerController controller;
	public MudarControles mc;

    public float jumpImpulse = 10.0f;

    private void Update()
    {
		if (controller.isGrounded && !controller.isStunned && mc.IsJumpDown())
            controller.playerRigidbody.AddForce(new Vector2(0.0f, jumpImpulse), ForceMode2D.Impulse);
    }
}