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

		private void ClearButton_Click(object sender, RoutedEventArgs e)
		{
			OutputTextBox.Text = string.Empty;
		}

		private void ButtonA_Click(object sender, RoutedEventArgs e)
		{
			// "0"		Zero placeholder
			// "#"		Digit placeholder
			//  "."		Decimal point

			double currentValue = 3355.752;
			string formattedString = String.Empty;
			// predefined
			formattedString = currentValue.ToString("E");
			OutputToScreen(formattedString);
			// with custom placeholders
			formattedString = currentValue.ToString("0.###000E+000"); 

			OutputToScreen(formattedString);

		}
		private void OutputToScreen(string message)
		{
			OutputTextBox.Text += message + "\r\n";
		}

		private void Buttonb_Click(object sender, RoutedEventArgs e)
		{
			
			// "D" or "d"	Decimal
			// "E" or "e"	Exponential
			// "F" or "f"	Fixed-point
			// "G" or "g"	General
			// "N" or "n"	Number
			// "P" or "p"	Percent
			// "X" or "x"	Hexadecimal

			double currentValue = Double.Parse(InputTextBox.Text);
			string formatter = FormatterTextBox.Text;
			try
			{
				string formattedString = currentValue.ToString($"{ formatter}");
				OutputToScreen(formattedString);
			} catch (Exception ex)
			{
				OutputToScreen($"Cannot format {ex.Message}");

			}
		}
	}
}
