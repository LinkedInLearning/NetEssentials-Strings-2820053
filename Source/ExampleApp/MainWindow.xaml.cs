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

			// use string constructors
			string s1 = String.Empty;
			string s2 = "";
			string s3 = "pear";
		
			OutputTextBox.Text = s1;
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e)
		{
			var db = new GroceryDb();
			string s2 = string.Empty;


			OutputTextBox.Text = s2;
		}

		private void ButtonC_Click(object sender, RoutedEventArgs e)
		{
			var db = new GroceryDb();
			string s3 = String.Empty;

			OutputTextBox.Text = s3;

		}
		private void ClearButton_Click(object sender, RoutedEventArgs e)
		{
			OutputTextBox.Text = string.Empty;
		}
	}
	public class GroceryDb
	{
		public char[] GetFruits()
		{
			// for example, a legacy service in your enterprise
			// that returns char arrays
			char[] fruits = { 'b', 'a', 'n', 'a', 'n', 'a', ',', 'f', 'i', 'g' };

			return fruits;
		}

	}
}
