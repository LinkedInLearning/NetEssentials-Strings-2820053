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
			string foods = "apple banana cherry durian eggplant fig grape  honey";
			OutputTextBox.Text += $"{foods}\r\n";
			// Split is used to break a delimited string into individual strings. 
			// which are added to a string array 

			var foodArray = foods.Split();
			foreach (var food in foodArray)
			{
				OutputTextBox.Text += $"{food}\r\n";
			}
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e)
		{
			string foods = "kiwi, lemon, mushroom, onion, potato, radish, spinach, tomato";
			OutputTextBox.Text += $"{foods}\r\n";

			string[] comma = { ", " };
			var foodArray = foods.Split(comma, StringSplitOptions.None);

			foreach (var food in foodArray)
			{
				OutputTextBox.Text += $"{food}\r\n";
			}

		}

		private void ButtonC_Click(object sender, RoutedEventArgs e)
		{
			string foods = "kiwi--banana--mushroom # eggplant # potato # grape.spinach.honey";
			OutputTextBox.Text += $"{foods}\r\n";
			string[] splitters = { ", ", "--", ".", " # " };

			var foodArray = foods.Split(splitters, StringSplitOptions.None);

			foreach (var food in foodArray)
			{
				OutputTextBox.Text += $"{food}\r\n";
			}
		}

		private void ButtonD_Click(object sender, RoutedEventArgs e)
		{
			string foods = "kiwi, , mushroom, onion, potato, , spinach, tomato";
			OutputTextBox.Text += $"{foods}\r\n";
			string[] comma = { ", " };
			var foodArray = foods.Split(comma, StringSplitOptions.RemoveEmptyEntries);

			foreach (var food in foodArray)
			{
				OutputTextBox.Text += $"{food}\r\n";
			}
		}
	}
}
