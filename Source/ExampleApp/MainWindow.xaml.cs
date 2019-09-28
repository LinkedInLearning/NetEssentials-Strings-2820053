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

		private CultureInfo _cultureUS = new CultureInfo("en-US");
		private CultureInfo _cultureDE = new CultureInfo("de-DE");
		private CultureInfo _cultureBN = new CultureInfo("bn-IN");
		private CultureInfo _cultureSG = new CultureInfo("zh-CN");


		private void ButtonA_Click(object sender, RoutedEventArgs e) {
			decimal saleAmount = 36450.89M;
			OutputTextBox1.Text += $"{_cultureUS.EnglishName}:\t\t{saleAmount.ToString("C", _cultureUS)}\r\n";
			OutputTextBox1.Text += $"{_cultureDE.EnglishName}:\t\t{saleAmount.ToString("C", _cultureDE)}\r\n";
			OutputTextBox1.Text += $"{_cultureBN.EnglishName}:\t\t\t{saleAmount.ToString("C", _cultureBN)}\r\n";
			OutputTextBox1.Text += $"{_cultureSG.EnglishName}:\t\t{saleAmount.ToString("C", _cultureSG)}\r\n";
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			DateTime saleDate = DateTime.Parse("7/21/2002 13:15:58", _cultureUS);

			OutputTextBox2.Text += $"{_cultureUS.EnglishName}:\t{saleDate.ToString("D", _cultureUS)}\r\n";
			OutputTextBox2.Text += $"{_cultureDE.EnglishName}:\t{saleDate.ToString("D", _cultureDE)}\r\n";
			OutputTextBox2.Text += $"{_cultureBN.EnglishName}:\t\t{saleDate.ToString("D", _cultureBN)}\r\n";
			OutputTextBox2.Text += $"{_cultureSG.EnglishName}:\t{saleDate.ToString("D", _cultureSG)}\r\n";

			OutputTextBox2.Text += $"--------------\r\n";

			OutputTextBox2.Text += $"{_cultureUS.EnglishName}:\t{saleDate.ToString("d", _cultureUS)}\r\n";
			OutputTextBox2.Text += $"{_cultureDE.EnglishName}:\t{saleDate.ToString("d", _cultureDE)}\r\n";
			OutputTextBox2.Text += $"{_cultureBN.EnglishName}:\t\t{saleDate.ToString("d", _cultureBN)}\r\n";
			OutputTextBox2.Text += $"{_cultureSG.EnglishName}:\t{saleDate.ToString("d", _cultureSG)}\r\n";

			OutputTextBox2.Text += $"--------------\r\n";
			OutputTextBox2.Text += $"{_cultureUS.EnglishName}:\t{saleDate.ToString("T", _cultureUS)}\r\n";
			OutputTextBox2.Text += $"{_cultureDE.EnglishName}:\t{saleDate.ToString("T", _cultureDE)}\r\n";
			OutputTextBox2.Text += $"{_cultureBN.EnglishName}:\t\t{saleDate.ToString("T", _cultureBN)}\r\n";
			OutputTextBox2.Text += $"{_cultureSG.EnglishName}:\t{saleDate.ToString("T", _cultureSG)}\r\n";
		}

	
		

		private void ClearButton_Click(object sender, RoutedEventArgs e) {
			OutputTextBox1.Text = OutputTextBox2.Text  = string.Empty;
		}
	}
}