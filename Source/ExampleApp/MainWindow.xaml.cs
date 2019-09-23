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
			// 0123456
			// 01234--	Remove(2)
			// ---3456  Remove(0,3)
			// 01----6	Remove(2,4)

			string sample = this.InputTextBox.Text;
			string prefix = "https://";

			if (sample.StartsWith(prefix))
			{
				OutputTextBox.Text = sample.Remove(0, prefix.Length);
			}
			else
			{
				OutputTextBox.Text = sample;
			}
		}
		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			string sample = this.InputTextBox.Text;
			string prefix = "https://";

			if (sample.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
			{
				OutputTextBox.Text = sample.Remove(0, prefix.Length);
			}
			else
			{
				OutputTextBox.Text = sample;
			}
		}

		private void ButtonC_Click(object sender, RoutedEventArgs e) {
			this.OutputTextBox.Text = string.Empty;
			string sample = "aa-ss-ee-dd-we-ss-44-ss-11-ss-d-ddf-ers";
			this.OutputTextBox.Text += sample + "\r\n";
			string replacedString = string.Empty ;
			OutputTextBox.Text += replacedString + "\r\n";
		}

		private void ButtonD_Click(object sender, RoutedEventArgs e) {
			string sample = "ace-bow-cow-dew @elf @fig @gum hue# icy# jam#";

			this.OutputTextBox.Text += sample + "\r\n";
			string replacedString = sample.Replace("-", ", ");
			OutputTextBox.Text += replacedString + "\r\n";
		}
	}
}
