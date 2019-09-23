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
			// #BFR--443!
			string inputString = InputTextBox.Text;
			string message = String.Empty;
			// String supports three methods to determine if a substring exists
			// Contains, StartsWith, EndsWith

			bool hasStartString, hasEndString, containsString;

			hasStartString = inputString.StartsWith("#");
			hasEndString = inputString.EndsWith("!");
			containsString = inputString.Contains("--");

			message = $"Starts with (#) :{hasStartString}, Contains (--): {containsString}, Ends with (!): {hasEndString}";
			OutputTextBox.Text = message;




		}
	}
}
