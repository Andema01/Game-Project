using Godot;
using System;

public class MoveObject : Node2D
{
	public override void _Ready()
	{
		
	}

	public void _Process(double delta)
	{
		
	}
	
	private void _on_Panel_gui_input(object @event)
	{
		if (@event is InputEventMouseButton eventMouseButton)
		{
			GD.Print("Mouse Click/Unclick at: ", eventMouseButton.Position);
			
			// Position += velocity * delta;
			// Position = new Vector2(
			// 	x: Mathf.Clamp(Position.x, 0, ScreenSize.x),
			// 	y: Mathf.Clamp(Position.y, 0, ScreenSize.y)
			// );
		}
		else if (@event is InputEventMouseMotion eventMouseMotion)
			GD.Print("Mouse Motion at: ", eventMouseMotion.Position);
		
		GD.Print("Viewport Resolution is: ", GetViewportRect().Size);
	}

}
