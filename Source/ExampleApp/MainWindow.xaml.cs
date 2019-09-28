using System;
using System.Globalization;
using System.Windows;

namespace ExampleApp {

	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {

		public MainWindow() {
			InitializeComponent();
		}

		private CultureInfo _ciUS = new CultureInfo("en-US");
		private CultureInfo _ciDE = new CultureInfo("de-DE");
		private CultureInfo _ciBN = new CultureInfo("bn-IN");
		private CultureInfo _ciCN = new CultureInfo("zh-CN");


		private void ButtonA_Click(object sender, RoutedEventArgs e) {
			decimal saleAmount = 36450.89M;
			OutputTextBox1.Text += $"{_ciUS.EnglishName}:\t\t{saleAmount.ToString("C", _ciUS)}\r\n";
			OutputTextBox1.Text += $"{_ciDE.EnglishName}:\t\t{saleAmount.ToString("C", _ciDE)}\r\n";
			OutputTextBox1.Text += $"{_ciBN.EnglishName}:\t\t\t{saleAmount.ToString("C", _ciBN)}\r\n";
			OutputTextBox1.Text += $"{_ciCN.EnglishName}:\t\t{saleAmount.ToString("C", _ciCN)}\r\n";
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			DateTime saleDate = DateTime.Parse("7/21/2002 13:15:58", _ciUS);

			OutputTextBox2.Text += $"{_ciUS.EnglishName}:\t{saleDate.ToString("D", _ciUS)}\r\n";
			OutputTextBox2.Text += $"{_ciDE.EnglishName}:\t{saleDate.ToString("D", _ciDE)}\r\n";
			OutputTextBox2.Text += $"{_ciBN.EnglishName}:\t\t{saleDate.ToString("D", _ciBN)}\r\n";
			OutputTextBox2.Text += $"{_ciCN.EnglishName}:\t{saleDate.ToString("D", _ciCN)}\r\n";

			OutputTextBox2.Text += $"--------------\r\n";

			OutputTextBox2.Text += $"{_ciUS.EnglishName}:\t{saleDate.ToString("d", _ciUS)}\r\n";
			OutputTextBox2.Text += $"{_ciDE.EnglishName}:\t{saleDate.ToString("d", _ciDE)}\r\n";
			OutputTextBox2.Text += $"{_ciBN.EnglishName}:\t\t{saleDate.ToString("d", _ciBN)}\r\n";
			OutputTextBox2.Text += $"{_ciCN.EnglishName}:\t{saleDate.ToString("d", _ciCN)}\r\n";

			OutputTextBox2.Text += $"--------------\r\n";
			OutputTextBox2.Text += $"{_ciUS.EnglishName}:\t{saleDate.ToString("T", _ciUS)}\r\n";
			OutputTextBox2.Text += $"{_ciDE.EnglishName}:\t{saleDate.ToString("T", _ciDE)}\r\n";
			OutputTextBox2.Text += $"{_ciBN.EnglishName}:\t\t{saleDate.ToString("T", _ciBN)}\r\n";
			OutputTextBox2.Text += $"{_ciCN.EnglishName}:\t{saleDate.ToString("T", _ciCN)}\r\n";
		}

	
		

		private void ClearButton_Click(object sender, RoutedEventArgs e) {
			OutputTextBox1.Text = OutputTextBox2.Text  = string.Empty;
		}
	}
}