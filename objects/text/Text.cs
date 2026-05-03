using Godot;
using System;
using static System.Net.Mime.MediaTypeNames;

public partial class Text : RigidBody2D
{
	Label label ;
	CollisionShape2D cs;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		label = GetNode<Label>("Label");
		cs = GetNode<CollisionShape2D>("CollisionShape2D");

		label.Text = Tr("test");

		{
			Vector2 getMinRectSize = label.GetCombinedMinimumSize();
			if (cs.Shape is RectangleShape2D rs) {
				rs.Size = getMinRectSize;
			}
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
