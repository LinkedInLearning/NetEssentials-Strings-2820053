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

		private List<string> _inputStrings = new List<string> { "123", "-45", "1,543", "(46)", "123.5", "", "hi" };

		private void ButtonA_Click(object sender, RoutedEventArgs e) {

			// The TryParse method is like the Parse method, 
			// except the TryParse method does not throw an exception 
			// if the conversion fails. 
			// It eliminates the need to use exception handling to test for a FormatException

			int intResult;

			foreach (var input in _inputStrings)
			{
				if (Int32.TryParse(input, System.Globalization.NumberStyles.Any, null, out intResult))
				{
					OutputTextBox.Text += $"{input}: converted to {intResult}\r\n";
				}
				else

				{
					OutputTextBox.Text += $"Cannot parse {input}: to Int32\r\n";
				}
			}
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			double doubleResult;

			foreach (var input in _inputStrings)
			{
				if (Double.TryParse(input, System.Globalization.NumberStyles.Any, null, out doubleResult))
				{
					OutputTextBox.Text += $"{input}: converted to {doubleResult}\r\n";
				}
				else

				{
					OutputTextBox.Text += $"Cannot parse {input}: to Double\r\n";
				}
			}
		}

		private void ButtonC_Click(object sender, RoutedEventArgs e) {
			var _inputStrings = new List<string> { "5/5/1925", "4/5", "July 21, 2002", "46", "January", "4:32:10", "4-4-44" };
			DateTime dateResult;
			foreach (var input in _inputStrings)
			{
				if (DateTime.TryParse(input,  null, System.Globalization.DateTimeStyles.AllowInnerWhite, out dateResult))
				{
					OutputTextBox.Text += $"{input}: converted to {dateResult}\r\n";
				}
				else

				{
					OutputTextBox.Text += $"Cannot parse {input}: to DateTime\r\n";
				}
			}
		}
	}
}