using System.Linq;
using System.Windows;

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
			foreach (var num in Enumerable.Range(1, 30))
			{
				OutputTextBox.Text += $"{num.FormatAsOrdinal()}\r\n";
			}
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			// code challenge:  Format as ordinal 

			// there is not a built in way to format number values as ordinal strings (1st, 2nd 3rd)
			// note that ordinal abbreviations are culture dependent, this challenge assume English ordinals.
			// create code that formats the number with an ordinal suffix.

			// 1st, 2nd, 3rd, 4th, 5th, 6th, 7th, 9th, 10th
			// 21st, 22nd, 23rd, 24th, etc
			// 31st, 32nd, 33rd, 34th, etc
			// 11th, 12th, 13th are special cases

			// use 

		}
	}
}