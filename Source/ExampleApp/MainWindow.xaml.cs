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

			RayPoint point = new RayPoint(144, 27);

			string s1 = point.ToString();
			OutputTextBox.Text += $"s1: {s1}\r\n";

			string s2 = point.ToString("H");
			OutputTextBox.Text += $"s2: {s2}\r\n";
			OutputTextBox.Text += $"s3: {point.ToString("F")}\r\n";
			OutputTextBox.Text += $"s4: {point:F}\r\n";


		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			RayPoint point = new RayPoint(144, 27);

			// .NET calls the ToString as needed
			Console.WriteLine(point);

			// .NET calls the ToString as needed
			string s4 = String.Concat("Use the String.Concat method: ", point);
			string s5 = $"The default ToString() value: ({point})\r\n";

		}
	}
}
