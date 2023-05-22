using System.Collections.Generic;
using Game.Scripts;
using Godot;
using Newtonsoft.Json;

/// <summary>
/// Создание файла с комбинациями
/// </summary>

public class Potions : Node
{
	public override void _Ready()
	{
		var flasks = new List<Flask>
		{
			//Базовые
			new Flask
			{
				Name = "Red",
				Color = "R",
				Price = 2d,
				Percent = 0d
			},
			new Flask
			{
				Name = "Yellow",
				Color = "Y",
				Price = 2d,
				Percent = 2d
			},
			new Flask
			{
				Name = "Blue",
				Color = "B",
				Price = 2d,
				Percent = 3d
			},
			new Flask
			{
				Name = "Orange",
				Color = "O",
				Price = 2d,
				Percent = 10d
			},
			new Flask
			{
				Name = "Purple",
				Color = "P",
				Price = 2d,
				Percent = 20d
			},
			new Flask
			{
				Name = "Green",
				Color = "G",
				Price = 2d,
				Percent = 10d
			},
			new Flask
			{
				Name = "White",
				Color = "W",
				Price = 10d,
				Percent = 30d
			},
			new Flask
			{
				Name = "Black",
				Color = "Z",
				Price = 10d,
				Percent = 10d
			},

			//Сложные
			new Flask
			{
				Name = "Зелье Очищения",
				Color = "RYB",
				Price = 10d,
				Percent = 15d
			},
			new Flask
			{
				Name = "Зелье Защиты",
				Color = "GBW",
				Price = 10d,
				Percent = 1d
			},
			new Flask
			{
				Name = "Зелье Долголетия",
				Color = "RYWG",
				Price = 20d,
				Percent = 6d
			},
			new Flask
			{
				Name = "Зелье Успеха",
				Color = "BOP",
				Price = 10d,
				Percent = 1d
			},
			new Flask
			{
				Name = "Зелье Энергии",
				Color = "YOG",
				Price = 10d,
				Percent = 1d
			},
			new Flask
			{
				Name = "Зелье Открытия",
				Color = "RPW",
				Price = 10d,
				Percent = 1d
			},
			new Flask
			{
				Name = "Зелье Расслабления",
				Color = "OW",
				Price = 5d,
				Percent = 1d
			},
			new Flask
			{
				Name = "Зелье Омоложения",
				Color = "GY",
				Price = 5d,
				Percent = 1d
			}
		};
		
		var str = JsonConvert.SerializeObject(flasks); 
		WriteToFile("res://Temp/potions.json", str);
		GD.Print("File ready");
	} 
	private static void WriteToFile(string path, string text)
	{
		var file = new File();
		
		file.Open(path, File.ModeFlags.Write);
		file.StoreLine(text);
		file.Close();
	}
}