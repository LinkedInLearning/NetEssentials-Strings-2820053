using System;
using System.Collections.Generic;
using System.Windows;

namespace ExampleApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void ClearButton_Click(object sender, RoutedEventArgs e)
		{
			OutputTextBox.Text = string.Empty;
		}

		private void ButtonA_Click(object sender, RoutedEventArgs e)
		{
			// The semicolon(;) is a conditional format specifier

			// No semicolon: the format applies all values
			// 1 semicolon:  Positive and Zero/Negative
			// 2 semicolon:  Positive/Negative/Zero

			double currentValue = Double.Parse(InputTextBox.Text);
			string formatter1 = "#,###;(#,###)";
			string formatter2 = "#,###;(#,###);**Zero**";

			try
			{
				string formattedString = currentValue.ToString($"{ formatter2}");
				OutputToScreen(formattedString);
			} catch (Exception ex)
			{
				OutputToScreen($"Cannot format {ex.Message}");
			}
		}

		private void OutputToScreen(string message)
		{
			OutputTextBox.Text += message + "\r\n";
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e)
		{
			List<int> numbers = new List<int> { 2, 4, 0, -6, -8 };
			OutputToScreen($"Always show number signs.");

			foreach (var number in numbers)
			{
				OutputToScreen($"{number:+#;-#;0} ");
			}
		}
	}
}