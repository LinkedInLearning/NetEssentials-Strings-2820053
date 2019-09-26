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
	}
}