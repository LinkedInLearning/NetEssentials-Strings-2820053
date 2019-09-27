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
		private CultureInfo _cultureInvariant = new CultureInfo("");
		private Decimal _saleAmountUS, _saleAmountDE;
		private string _amountAsUsCurrency1, _amountAsDeCurrency1, _amountAsInvariantCurrency1;
		private string _amountAsUsCurrency2, _amountAsDeCurrency2, _amountAsInvariantCurrency2;

		private void ButtonA_Click(object sender, RoutedEventArgs e) {
			try
			{
				ParseDataUS();
				OutputTextBox1.Text += $"US:\t\t{_amountAsUsCurrency1}\r\n";
				OutputTextBox1.Text += $"DE:\t\t{_amountAsDeCurrency1}\r\n";
				OutputTextBox1.Text += $"Invariant:\t{_amountAsInvariantCurrency1}\r\n";
			} catch (Exception)
			{
				throw;
			}
		}

	

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			try
			{
				ParseDataDE();

				OutputTextBox2.Text += $"US:\t\t{_amountAsUsCurrency2}\r\n";
				OutputTextBox2.Text += $"DE:\t\t{_amountAsDeCurrency2}\r\n";
				OutputTextBox2.Text += $"Invariant:\t{_amountAsInvariantCurrency2}\r\n";
			} catch (Exception)
			{
				throw;
			}
		}

		private void ParseDataUS() {
			_saleAmountUS = Decimal.Parse(InputTextBox.Text, NumberStyles.Any, _cultureUS);
			_amountAsUsCurrency1 = _saleAmountUS.ToString("C", _cultureUS);
			_amountAsDeCurrency1 = _saleAmountUS.ToString("C", _cultureDE);
			_amountAsInvariantCurrency1 = _saleAmountUS.ToString("C", _cultureInvariant); ;
		}

		private void ParseDataDE() {
			_saleAmountDE = Decimal.Parse(InputTextBoxDE.Text, NumberStyles.Any, _cultureDE);
			_amountAsUsCurrency2 = _saleAmountDE.ToString("C", _cultureUS);
			_amountAsDeCurrency2 = _saleAmountDE.ToString("C", _cultureDE);
			_amountAsInvariantCurrency2 = _saleAmountDE.ToString("C", _cultureInvariant);
		}

		private void ButtonC_Click(object sender, RoutedEventArgs e) {
			// use invariant versions for comparison where culture isn't important
		
			ParseDataUS();
			ParseDataDE();
			if (_amountAsInvariantCurrency1 == _amountAsInvariantCurrency2)
			{
				OutputTextBox3.Text += $"{_amountAsInvariantCurrency1} == {_amountAsInvariantCurrency2}\r\n";
			}
			else

			{
				OutputTextBox3.Text += $"{_amountAsInvariantCurrency1} != {_amountAsInvariantCurrency2}\r\n";
			}
		}
		private void ButtonD_Click(object sender, RoutedEventArgs e) {
			InputTextBox.Text = "4,615.44";
			InputTextBoxDE.Text = "4.615,44";
		}
		private void ClearButton_Click(object sender, RoutedEventArgs e) {
			OutputTextBox1.Text = OutputTextBox2.Text = OutputTextBox3.Text = string.Empty;
		}
	}
}