using UnityEngine;

public sealed class EnemySprite : MonoBehaviour
{
	public EnemyController controller;
	public SpriteRenderer spriteRenderer;
	public bool flipSprites = false;

	private void Update()
	{
		spriteRenderer.flipX = flipSprites != controller.invertedMovement;
	}
}
