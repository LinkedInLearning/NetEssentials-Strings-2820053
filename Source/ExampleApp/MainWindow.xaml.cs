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
			// "C" or "c"	Currency
			// "D" or "d"	Decimal
			// "E" or "e"	Exponential
			// "F" or "f"	Fixed-point
			// "G" or "g"	General
			// "N" or "n"	Number
			// "P" or "p"	Percent
			// "X" or "x"	Hexadecimal

			double currentValue = 3355.123;
			
			try
			{
				string formattedString = currentValue.ToString("E");

				
				OutputToScreen(formattedString);
			} catch (Exception ex)
			{
				OutputToScreen($"Cannot format {ex.Message}");

			}


		}
		

		private void ButtonB_Click(object sender, RoutedEventArgs e)
		{
			// "C" or "c"	Currency
			// "D" or "d"	Decimal
			// "E" or "e"	Exponential
			// "F" or "f"	Fixed-point
			// "G" or "g"	General
			// "N" or "n"	Number
			// "P" or "p"	Percent
			// "X" or "x"	Hexadecimal

			int currentValue = int.Parse(InputTextBox.Text);
			string formatter = FormatterTextBox.Text;
			try
			{
				//string formattedString = currentValue.ToString("E");

				string formattedString = currentValue.ToString($"{ formatter}");
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
	}
}
