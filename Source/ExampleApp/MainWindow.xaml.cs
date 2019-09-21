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
		string [] foodArray =  { "banana", "celery", "kiwi", "onion", "potato", "cherry" };

			string foodString = String.Join("--=--", foodArray);

			this.OutputTextBox.Text = foodString;

		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			List<string> foodList = new List<string>{ "banana", "celery", "kiwi", "onion", "potato", "cherry" };

			string foodString = String.Join("#", foodList);

			this.OutputTextBox.Text = foodString;
		}

		private void ButtonC_Click(object sender, RoutedEventArgs e) {

			List<double> numbers = new List<double> { 1.5, 2.5, 3.5, 8.5, 7.5, 6.5 };

			string numbersString = String.Join(" + ", numbers);
			this.OutputTextBox.Text = numbersString;
		}
	}
}
