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

		private void ClearButton_Click(object sender, RoutedEventArgs e) {
			OutputTextBox.Text = string.Empty;
		}

		private void ButtonA_Click(object sender, RoutedEventArgs e) {

			// Use String.Format if you need to insert the value 
			// of an object, variable, or expression into another string.


			// Additionally, the value inserted can be formatted
			// 24 => $24.00
			// .400 => 40%

			string outputString = string.Empty;
			double num1 = 24.75;

			outputString = String.Format("{0}", num1);
			OutputTextBox.Text = outputString;
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			double num1 = .12;
			double num2 = .15;

			string header = "Format these numbers as percent: ";
			string combo = string.Empty;
			combo = String.Format("{0}{1}, {2}", header, num1, num2);

			OutputTextBox.Text = combo;
		}

		private void ButtonC_Click(object sender, RoutedEventArgs e) {
			// combine two strings with String methods

			string first = "1. The Banana is yellow.";
			string second = "2. The pear is ripe.";
			string third = "3. A tomato is not a vegetable, it's a fruit!";
			string florette = " ✿ ";

			string combo = string.Empty;

			combo = String.Format("{0}{1}{2}", first, florette, second);
			OutputTextBox.Text = combo;
		}
	}
}
