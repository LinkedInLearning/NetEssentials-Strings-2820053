using System;
using System.Collections.Generic;
using System.Windows;

namespace ExampleApp {

	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {

		public MainWindow() {
			InitializeComponent();
		}

		private void ClearButton_Click(object sender, RoutedEventArgs e) {
			OutputTextBox.Text = string.Empty;
		}

		private void ButtonA_Click(object sender, RoutedEventArgs e) {
			int result;

			var inputString = new List<string> { "123", "-45", "1,543", "123.5", "(46)", "", "hi" };

			foreach (var input in inputString)
			{
				try
				{
					result = Convert.ToInt32(input);
					OutputTextBox.Text += $"{input}: converted to {input}\r\n";
				} catch (Exception)
				{
					result = 0;
					OutputTextBox.Text += $"Cannot convert \"{input}\" to an Int32.\r\n";
				}
			}
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			double result;

			var inputString = new List<string> { "123", "-45", "1,543", "123.5", "(46)", "", "hi" };

			foreach (var input in inputString)
			{
				try
				{
					result = Convert.ToDouble(input);
					OutputTextBox.Text += $"{input}: converted to {input}\r\n";
				} catch (Exception)
				{
					result = 0;
					OutputTextBox.Text += $"Cannot convert \"{input}\" to an Double.\r\n";
				}
			}
		}

		private void ButtonC_Click(object sender, RoutedEventArgs e) {
			int result;

			var inputString = new List<string> { "123", "-45", "1,543", "123.5", "(46)", "", "hi" };

			foreach (var input in inputString)
			{
				try
				{
					result = Int32.Parse(input, System.Globalization.NumberStyles.Any);
					OutputTextBox.Text += $"{input}: converted to {input}\r\n";
				} catch (Exception)
				{
					result = 0;
					OutputTextBox.Text += $"Cannot convert \"{input}\" to an Int32.\r\n";
				}
			}
		}
	}
}