using System;

namespace CarLot.Lesson3Review
{
	public class Solution
	{
		public class Logger
		{
			public class Line
			{
				public string Text { get; }
				public ConsoleColor? ForegroundColor { get; }
				public ConsoleColor? BackgroundColor { get; }

				public Line(string text = null, ConsoleColor? foregroundColor = null, ConsoleColor? backgroundColor = null)
				{
					// Set text
					Text = text;
					// Set foreground color
					ForegroundColor = foregroundColor;
					// Set background color
					BackgroundColor = backgroundColor;
				}
			}

			public int Spacing { get; set; }
			public string Divider { get; set; }
			public ConsoleColor ForegroundColorDefault { get; set; }
			public ConsoleColor BackgroundColorDefault { get; set; }

			public Logger
			(
				int spacing = 1,
				string divider = "=====", 
				ConsoleColor? foregroundColorDefault = null, 
				ConsoleColor? backgroundColorDefault = null
			)
			{
				// Set spacing
				Spacing = spacing;
				// Set divider
				Divider = divider;
				// Set default colors
				_SetColorsDefault(foregroundColorDefault, backgroundColorDefault);
			}

			public void Log(params string[] texts)
			{
				// Create lines
				var lines = new Line[texts.Length];
				// Run through texts
				for (int i = 0; i < texts.Length; i++)
				{
					// Add line
					lines[i] = new Line(texts[i]);
				}
				// Log
				Log(lines);
			}
			public void Log(params Line[] lines)
			{
				// Write spacing
				_WriteSpacing();
				// Run through lines
				for (int i = 0; i < lines.Length; i++)
				{
					// Write line
					_WriteLine(lines[i]);
				}
				// Check if divider exists
				if (_ExistsDivider())
				{
					// Write spacing
					_WriteSpacing();
					// Write divider
					_WriteDivider();
				}
			}

			private void _WriteLine(Line line)
			{
				// Maintain current colors
				_MaintainColorsCurrent(() =>
				{
					// Set foreground color
					Console.ForegroundColor = line.ForegroundColor ?? ForegroundColorDefault;
					// Set background color
					Console.BackgroundColor = line.BackgroundColor ?? BackgroundColorDefault;
					// Write line
					Console.WriteLine(line.Text);
				});
			}

			private void _WriteSpacing()
			{
				// Run through spacing
				for (int i = 0; i < Spacing; i++)
				{
					// Write spacing
					Console.WriteLine();
				}
			}

			private bool _ExistsDivider()
			{
				// Return if divider exists
				return !string.IsNullOrWhiteSpace(Divider);
			}

			private void _WriteDivider()
			{
				// Write divider
				Console.WriteLine(Divider);
			}

			private void _SetColorsDefault(ConsoleColor? foregroundColorDefault, ConsoleColor? backgroundColorDefault)
			{
				// Maintain current colors
				_MaintainColorsCurrent(() =>
				{
					// Reset console color
					Console.ResetColor();
					// Get default foreground color
					var foregroundColorDefaultSystem = Console.ForegroundColor;
					// Get default background color
					var backgroundColorDefaultSystem = Console.BackgroundColor;
					// Set foreground color
					ForegroundColorDefault = foregroundColorDefault ?? foregroundColorDefaultSystem;
					// Set background color
					BackgroundColorDefault = backgroundColorDefault ?? backgroundColorDefaultSystem;
				});
			}

			private void _MaintainColorsCurrent(Action action)
			{
				// Get current foreground color
				var foregroundColorCurrent = Console.ForegroundColor;
				// Get current background color
				var backgroundColorCurrent = Console.BackgroundColor;
				// Do action
				action();
				// Set foreground color
				Console.ForegroundColor = foregroundColorCurrent;
				// Set background color
				Console.BackgroundColor = backgroundColorCurrent;
			}
		}
	}
}
