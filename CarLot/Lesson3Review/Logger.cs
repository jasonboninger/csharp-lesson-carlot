using System;

namespace CarLot.Lesson3Review
{
	public class Logger
	{
		public class Line
		{
			public string Text { get; }
			public ConsoleColor? BackgroundColor { get; }
			public ConsoleColor? ForegroundColor { get; }

			public Line(string text, ConsoleColor? backgroundColor = null, ConsoleColor? foregroundColor = null)
			{
				// Set text
				Text = text;
				// Set background color
				BackgroundColor = backgroundColor;
				// Set foreground color
				ForegroundColor = foregroundColor;
			}
		}

		private string _divider;
		private int _spacing;

		public Logger(string divider = "-----", int spacing = 1)
		{
			// Set divider
			_divider = divider;
			// Set spacing
			_spacing = spacing;
		}

		public void Log(params string[] texts)
		{
			// Create lines
			var lines = new Line[texts.Length];
			// Run through texts
			for (int i = 0; i < texts.Length; i++)
			{
				// Create line
				lines[i] = new Line(texts[i]);
			}
			// Log lines
			Log(lines);
		}
		public void Log(params Line[] lines)
		{
			// Add spacing
			_AddSpacing();
			// Run through lines
			for (int i = 0; i < lines.Length; i++)
			{
				var line = lines[i];
				// Use background color
				_UseBackgroundColor(line.BackgroundColor, () =>
				{
					// Log the line
					Console.WriteLine(line.Text);
				});
			}
			// Check if the divider exists
			if (_ExistsDivider())
			{
				// Add spacing
				_AddSpacing();
				// Add divider
				_AddDivider();
			}
		}

		private void _UseBackgroundColor(ConsoleColor? backgroundColor, Action action)
		{
			// Get the original background color
			var backgroundColorOriginal = Console.BackgroundColor;
			// Check if back color exists
			if (backgroundColor.HasValue)
			{
				// Set background color
				Console.BackgroundColor = backgroundColor.Value;
			}
			// Do action
			action();
			// Set the background color back to the original
			Console.BackgroundColor = backgroundColorOriginal;
		}

		private bool _ExistsDivider()
		{
			// Return if divider line exists
			return !string.IsNullOrWhiteSpace(_divider);
		}

		private void _AddDivider()
		{
			// Write a divider line
			Console.WriteLine(_divider);
		}

		private void _AddSpacing()
		{
			// Add spacing
			for (int i = 0; i < _spacing; i++)
			{
				// Write a blank line
				Console.WriteLine();
			}
		}
	}
}
