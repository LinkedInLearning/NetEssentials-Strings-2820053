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

			RayPoint point = new RayPoint();
			string userString = InputTextBox.Text;
			try
			{
				point = RayPoint.Parse(userString);
			} catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}


			OutputTextBox.Text += point.ToString() + "\r\n";
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			RayPoint point = new RayPoint();
			string userString = InputTextBox.Text;

			if (RayPoint.TryParse(userString, out point))
			{
				OutputTextBox.Text += point.ToString() + "\r\n";
			}
			else
			{
				OutputTextBox.Text += "Cannot parse that value, try again.\r\n";
			}
		}
	}
}
