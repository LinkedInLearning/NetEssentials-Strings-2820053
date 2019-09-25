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

namespace ExampleApp {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void ClearButton_Click(object sender, RoutedEventArgs e) {
			OutputTextBox.Text = string.Empty;
		}

		private void ButtonA_Click(object sender, RoutedEventArgs e) {


			OutputTextBox.Text += point.ToString() + "\r\n";
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {

			RayPoint point;
			string userString = "30,40";
			point = RayPoint.Parse(userString);
			// code challenge:  
			// write a method that returns a three values (boolean, X, Y) 
			// method has one string parameter
			// the goal is to parse the incoming string and split into two numbers
			// return the X and Y values
			// return true for these test cases
			userString = "abc30,40";
			userString = "30,40def";
			userString = "  30,40  ";
			userString = "-30,40";
			userString = "30, -40";
			// return false for these test cases
			userString = "30, 40, 50"; // more than two numbers, not valid
			userString = "30"; // less than two numbers, not valid
			userString = "abc";
			userString = "30 40" // this is an edge case, can you parse the data with comma or with space?
		}

		public ParsedData CodeChallenge(string value) {
			var parsed = new ParsedData();
			return parsed;
	}

	}
	public struct ParsedData {
		public bool WasParsed { get; set; }
		public int X { get; set; }
		public int Y { get; set; }

	}
}
