using Godot;

public partial class Player : CharacterBody2D {

	/// <summary>
	/// 移动速度
	/// </summary>
	[Export]
	public float speed = 300.0f;

	/// <summary>
	/// 单帧移动增量，控制加减速平滑度
	/// </summary>
	[Export]
	public float moveDelta = 900f;

	/// <summary>
	/// 基本推力
	/// </summary>
	[Export] 
	public float pushBasicForce = 20.0f;

	public override void _PhysicsProcess(double delta) {
		Vector2 velocity = Velocity;

		{
			Vector2 direction = Input.GetVector("moveLeft", "moveRight", "moveUp", "moveDown");
			velocity = direction * speed;
			velocity = Velocity.MoveToward(velocity, moveDelta * (float)delta);
		}

		Velocity = velocity;
		MoveAndSlide();

		for (int i = 0; i < GetSlideCollisionCount(); i++) {
			KinematicCollision2D collision = GetSlideCollision(i);

			if (collision.GetCollider() is RigidBody2D rigidBody) {
				rigidBody.ApplyCentralImpulse(
					pushBasicForce * 
					(-collision.GetNormal())
					);
			}
		}
	}
}
