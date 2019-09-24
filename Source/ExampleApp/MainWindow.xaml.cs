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

			point.X += 12;
			point.Y -= 6;

			string s1 = point.ToString();
			Console.WriteLine(point);

			string s2 = String.Concat("Use the String.Concat method: ", point);

			string s3 = $"The default ToString() value: ({point})";

			OutputTextBox.Text = s3;
		}
	}
}
