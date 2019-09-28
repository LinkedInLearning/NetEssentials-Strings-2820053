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

			// German and English culture both consider ss == ß 

			// use compare to determine >, =, < 
			string ss = "ss";
			string ess = "ß";
			string a = "a";
			string b = "b";
			int result;

			// string compare defaults to culture-sensitive
			result = string.Compare("a", "b");
			OutputToScreen($"Culture: (a) compared to (b) is {result}");
			result = string.Compare("b", "a");
			OutputToScreen($"Culture: (b) compared to (a) is {result}");

			//there is also a CompareTo
			result = b.CompareTo(a);
			result = a.CompareTo(b);

			result = string.Compare("a", "a");
			OutputToScreen($"Culture: (a) compared to (a) is {result}");

			result = string.Compare("a", "z");
			OutputToScreen($"Culture: (a) compared to (z) is {result}");
			OutputToScreen("-----");
			result = string.Compare("a", "z", StringComparison.Ordinal);
			OutputToScreen($"Ordinal: (a) compared to (z) is {result}");

			result = string.Compare("a", "r", StringComparison.Ordinal);
			OutputToScreen($"Ordinal: (a) compared to (r) is {result}");

			result = string.Compare(ss, ess);
			OutputToScreen($"Culture: (ss) compared to (ß) is {result}");

			result = string.Compare(ss, ess, StringComparison.Ordinal);
			OutputToScreen($"Ordinal: (ss) compared to (ß) is {result}");

			OutputToScreen("-----");

			result = string.Compare("banana", "bAnAnA", StringComparison.CurrentCulture);
			OutputToScreen($"Culture: (banana) compared to (bAnAnA) is {result}");
			result = string.Compare("banana", "bAnAnA", StringComparison.Ordinal);
			OutputToScreen($"Ordinal: (banana) compared to (bAnAnA) is {result}");

			result = string.Compare("banana", "breadFruit", StringComparison.Ordinal);
			OutputToScreen($"Ordinal: (banana) compared to (breadFruit) is {result}");
		}

		private void OutputToScreen(string message) {

			OutputTextBox.Text += $"{message}\r\n";
		}
	}
}
