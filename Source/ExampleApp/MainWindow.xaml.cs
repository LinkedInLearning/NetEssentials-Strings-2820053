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
			var culture = new System.Globalization.CultureInfo("se-SV");


			string s1 = point.ToString();
			string s2 = point.ToString("C");
			string s3 = point.ToString("H", culture);

			OutputTextBox.Text += $"s1: {s1}\r\n";
			OutputTextBox.Text += $"s2: {s2}\r\n";
			OutputTextBox.Text += $"s3: {s3}\r\n";

		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {

			RayPoint point = new RayPoint(144, 27);
			Console.WriteLine(point);

			string s2 = String.Concat("Use the String.Concat method: ", point);

			string s3 = $"The default ToString() value: ({point})";
			string s4 = $"The default ToString() value: ({point:X})";

	
		}
	}
}
