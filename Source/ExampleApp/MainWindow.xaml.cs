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
			string sample = "   At Roux, our mission is to teach and inspire the next generation’s artists to create work that changes the way people think, and hopefully, even the way they act. We believe art inspires compassion by providing audiences with an empathetic outlet.  ";


			string trimmedString  = string.Empty;
		
			OutputTextBox.Text = trimmedString;
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			string sample = " ,,../   At Roux, our mission is to teach and inspire the next generation’s artists to create work that changes the way people think, and hopefully, even the way they act. We believe art inspires compassion by providing audiences with an empathetic outlet.  ";
			char[] charsToTrim = { ',', '.', ' ','/' };
			var trimmedString = sample.Trim().TrimStart(charsToTrim);
			OutputTextBox.Text = trimmedString;
		}
	}
}
