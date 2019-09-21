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
			string foodsA = "apple banana cherry durian eggplant fig grape honey ice";

			string foodsB = "kiwi, lemon, mushroom, onion, potato, radish, spinach, tomato";

			string foodsC = "kiwi--banana--mushroom # eggplant # potato # grape.spinach.honey";

			//  split into a string array

			var foodArrayA = foodsA.Split();

			string[] comma = { ", " };
			var foodArrayB = foodsB.Split(comma, StringSplitOptions.None);

			string[] splitters = { ", ", "--", ".", " # " };

			var foodArrayC = foodsC.Split(splitters, StringSplitOptions.None);
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			string foodsB = "kiwi, , mushroom, onion, potato, , spinach, tomato";

			string[] comma = { ", " };
			var foodArrayB = foodsB.Split(comma, StringSplitOptions.RemoveEmptyEntries);
	
		}

		private void ButtonC_Click(object sender, RoutedEventArgs e) {
			string foodsB = "kiwi, lemon, kiwi, onion, potato, lemon, spinach, tomato, lemon";
			string[] comma = { ", " };

			
			var foodArrayB = foodsB.Split(comma, StringSplitOptions.RemoveEmptyEntries);
			var q = foodArrayB.GroupBy(x => x).Select(x=> new {FoodName=x.Key,WordCount = x.Count() });

			foreach (var item in q)
			{
				OutputTextBox.Text += $"{item.FoodName}: {item.WordCount}\r\n";
			}
			
		}
	}
}
