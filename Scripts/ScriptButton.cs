using Godot;
using System;

public class ScriptButton : Button
{
	private const string PathToRoot = "res://Scenes/Root.tscn";
	private const string PathToSetting = "res://Scenes/Setting.tscn";
	
	public override void _Ready() { }
	
	private void _on_Play_pressed() => GetTree().ChangeScene(PathToRoot);

	private void _on_Setting_pressed() => GetTree().ChangeScene(PathToSetting);

	private void _on_Exit_pressed() => GetTree().Quit();
}
