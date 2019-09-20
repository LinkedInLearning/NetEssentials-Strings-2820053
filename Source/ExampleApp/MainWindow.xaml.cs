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
			// string interpolation is similar to String.Format
			// Improvements over String.Format
			// 1. Tokens/placeholders available in "", no need to call String.Format()
			// 2. No need to use index values {0}{1}, use expression directly {num1}{num2}


			double num1 = .12;
			double num2 = .15;

			string header = "Format these numbers as percent: ";
			string combo = string.Empty;
			combo = String.Format("{0}{1:P}, {2:P}", header, num1, num2);

			OutputTextBox.Text = combo;

			
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			
		}

		private void ClearButton_Click(object sender, RoutedEventArgs e)
		{
			OutputTextBox.Text = string.Empty;
		}
	}
}
