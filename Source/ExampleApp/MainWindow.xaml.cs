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
			// combine multiple strings with the + operator
		

			string first = "1. The Banana is yellow.";
			string second = "2. The pear is ripe.";
			string third = "3. A tomato is not a vegetable, it's a fruit!";
			string florette = " ✿ ";

			string combo = string.Empty;

			
			OutputTextBox.Text = combo;
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {

			// the plus operator performs addition with numeric variables

			int num1= 12;
			int num2 = 15;

			string header = "The total is: ";
			string combo = string.Empty;


			combo = header + num1 + num2;
			// or
			combo = header + (num1 + num2);
			OutputTextBox.Text = combo;
		}
	}
}
