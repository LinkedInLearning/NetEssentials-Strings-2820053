using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExampleApp {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}



		private void ButtonA_Click(object sender, RoutedEventArgs e) {
			string longString = "01-02-03-04-05-06-07-08-09-10-11-12-13-14-15-16-17-18-19-20";

			string sub1 = longString.Substring(18);
			string sub2 = longString.Substring(18, 8);


			OutputTextBox.Text += sub1 + "\r\n";
			OutputTextBox.Text += sub2 + "\r\n";
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			string longString = "AA212-BB102-CC453-BT455-TR376-GH003-QR417-NV018-AG204-LJ122";
			string result = string.Empty;
			// use Contains to determine if a sub string exists
			// use IndexOf to get index of substring
			OutputTextBox.Text += longString + "\r\n";
			string searchString = InputTextBox.Text;

			if (longString.Contains(searchString))
			{
				int index = longString.IndexOf(searchString);
				result = longString.Substring(index + 2, 3);

				OutputTextBox.Text += $"Ticket Code: {searchString} is {result}\r\n";
			}
		}

		private void ClearButton_Click(object sender, RoutedEventArgs e) {
			OutputTextBox.Text = string.Empty;
		}
	}
}
