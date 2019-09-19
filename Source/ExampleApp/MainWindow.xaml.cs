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

		

		private void ButtonA_Click(object sender, RoutedEventArgs e) {
			// Escape sequences represent non-printable and special characters in literal strings. 
			// Originally used to send commands to hardware devices like printers and display terminal
			// They are still useful for embedded tabs, line feed and similar into the string

			// use the \ to indicate the start of the escape sequence.

			// \', \", \\

			var s1 = "The customer said, \"I want a refund\".";
			OutputTextBox.Text = s1;

		

		}


		

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			// \r carriage return, \n new line
			var s2 = "The first line.\r\nThe second line";
			OutputTextBox.Text = s2;
		}

		

		private void ButtonC_Click(object sender, RoutedEventArgs e) {
			// \t horizontal tab, \v vertical tab
			var s3 = "aaa\t\bbb\tccc\vddd\teee\tfff\a";
			OutputTextBox.Text = s3;
		}

	

		private void ButtonD_Click(object sender, RoutedEventArgs e) {
			//	\\ Backslash used for file path
			var s4 = "C:\\users\\walt\\documents";

			OutputTextBox.Text = s4;
		}

	

		private void ButtonE_Click(object sender, RoutedEventArgs e) {
			// \u to inject unicode into string
			var s5 = "Add any Unicode code point:\v\u2600 \u2614 \u2615 \u273F \r\n\u2600 \u2614 \u2615 \u273F ";
			OutputTextBox.Text = s5;
		}

		private void ClearButton_Click(object sender, RoutedEventArgs e) {
			OutputTextBox.Text = string.Empty;
		}
	}
}
