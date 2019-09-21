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
			string foods = "kiwi, lemon, kiwi, onion, potato, lemon, spinach, tomato, lemon, onion";
			string[] comma = { ", " };


			var foodArrayB = foods.Split(comma, StringSplitOptions.RemoveEmptyEntries);

			var countQuery = foodArrayB.GroupBy(x => x);

			foreach (var foodItem in countQuery)
			{
				OutputTextBox.Text += $"{foodItem.Key}: {foodItem.Count()}\r\n";
			}

		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {

			string statusCodes = "#kr032,#rt887,#kr932,#wt187,#aa321,#bb872,#dm554";

			

			var statusArray = statusCodes.Split(',');

		

			foreach (var status in statusArray)
			{
				OutputTextBox.Text += $"{status} \r\n";
			}
			OutputTextBox.Text += "------------\r\n";

			// 	var query = statusArray.Where(x => x.Contains("87"));
			//foreach (var status in query)
			//{
			//	OutputTextBox.Text += $"{status} \r\n";
			//}
		}
	}
}
