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


		private void ButtonA_Click(object sender, RoutedEventArgs e)
		{
			Char c1 = '.';
			Char c2 = '3';
			// How would you test for punctuation?
			if (c1 == '.' || c1 == '!' || c1 == ',' || c1 == ';' || c1 == ':' || c1 == '?')
			{
				// do something
			}

			// How do you test for numeric?
			if (c2 == '0' || c2 == '1' || c2 == '2' || c2 == '3' || c2 == '4' || c2 == '5')
			{
				// do something
			}
		}


		//	https://docs.microsoft.com/en-us/dotnet/api/system.char.ispunctuation?view=netframework-4.8
		private void ButtonB_Click(object sender, RoutedEventArgs e)
		{
			Char c1 = '.';
			// use the Char methods to test for Unicode categories.

			if (true)
			{
				// determine if this char is considered a punctuation
				// by the Unicode Standards.
			}
		}

		private void InputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			Char currentChar = e.Text[0];

			if (Char.IsDigit(currentChar))
			{
				e.Handled = true;
			}
		}
		private void ClearButton_Click(object sender, RoutedEventArgs e)
		{
			OutputTextBox.Text = string.Empty;
		}
	}
}
