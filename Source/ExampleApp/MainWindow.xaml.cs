using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace ExampleApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void ClearButton_Click(object sender, RoutedEventArgs e) {
			OutputTextBox1.Text = OutputTextBox2.Text = OutputTextBox3.Text = string.Empty;
		}

		private void ButtonA_Click(object sender, RoutedEventArgs e) {
			var culture1 = new System.Globalization.CultureInfo("en-US");
			var culture2 = new System.Globalization.CultureInfo("fr-BE");
			var culture3 = new System.Globalization.CultureInfo("zh-SG");

			OutputTextBox1.Text += $"Culture ID: {culture1.Name}\r\n";
			OutputTextBox2.Text += $"Culture ID: {culture2.Name}\r\n";
			OutputTextBox3.Text += $"Culture ID: {culture3.Name}\r\n";

			OutputTextBox1.Text += $"English Name: {culture1.EnglishName	}\r\n";
			OutputTextBox2.Text += $"English Name: {culture2.EnglishName}\r\n";
			OutputTextBox3.Text += $"English Name: {culture3.EnglishName}\r\n";

			OutputTextBox1.Text += $"Native Name: {culture1.NativeName  }\r\n";
			OutputTextBox2.Text += $"Native Name: {culture2.NativeName}\r\n";
			OutputTextBox3.Text += $"Native Name: {culture3.NativeName}\r\n";

			OutputTextBox1.Text += $"-----------------\r\n";
			OutputTextBox2.Text += $"-----------------\r\n";
			OutputTextBox3.Text += $"-----------------\r\n";

			OutputTextBox1.Text += $"Native Calendar: {culture1.DateTimeFormat.NativeCalendarName }\r\n";
			OutputTextBox2.Text += $"Native Calendar: {culture2.DateTimeFormat.NativeCalendarName}\r\n";
			OutputTextBox3.Text += $"Native Calendar: {culture3.DateTimeFormat.NativeCalendarName}\r\n";

			OutputTextBox1.Text += $"Month Day Pattern: {culture1.DateTimeFormat.LongDatePattern  }\r\n";
			OutputTextBox2.Text += $"Month Day Pattern: {culture2.DateTimeFormat.LongDatePattern}\r\n";
			OutputTextBox3.Text += $"Month Day Pattern: {culture3.DateTimeFormat.LongDatePattern}\r\n";

			


			OutputTextBox1.Text += $"-----------------\r\n";
			OutputTextBox2.Text += $"-----------------\r\n";
			OutputTextBox3.Text += $"-----------------\r\n";

			OutputTextBox1.Text += $"NumberDecimalSeparator: {culture1.NumberFormat.NumberDecimalSeparator }\r\n";
			OutputTextBox2.Text += $"NumberDecimalSeparator: {culture2.NumberFormat.NumberDecimalSeparator }\r\n";
			OutputTextBox3.Text += $"NumberDecimalSeparator: {culture3.NumberFormat.NumberDecimalSeparator }\r\n";

			OutputTextBox1.Text += $"NumberGroupSeparator: {culture1.NumberFormat.NumberGroupSeparator }\r\n";
			OutputTextBox2.Text += $"NumberGroupSeparator: {culture2.NumberFormat.NumberGroupSeparator }\r\n";
			OutputTextBox3.Text += $"NumberGroupSeparator: {culture3.NumberFormat.NumberGroupSeparator }\r\n";

			OutputTextBox1.Text += $"CurrencySymbol: {culture1.NumberFormat.CurrencySymbol }\r\n";
			OutputTextBox2.Text += $"CurrencySymbol: {culture2.NumberFormat.CurrencySymbol }\r\n";
			OutputTextBox3.Text += $"CurrencySymbol: {culture3.NumberFormat.CurrencySymbol }\r\n";

			OutputTextBox1.Text += $"NumberDecimalDigits: {culture1.NumberFormat.NumberDecimalDigits }\r\n";
			OutputTextBox2.Text += $"NumberDecimalDigits: {culture2.NumberFormat.NumberDecimalDigits }\r\n";
			OutputTextBox3.Text += $"NumberDecimalDigits: {culture3.NumberFormat.NumberDecimalDigits }\r\n";
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			var culture1 = new System.Globalization.CultureInfo("en-US");
			var culture2 = new System.Globalization.CultureInfo("fr-BE");
			var culture3 = new System.Globalization.CultureInfo("zh-SG");

			OutputTextBox1.Text += $"Month Names\r\n";
			OutputTextBox2.Text += $"Month Names\r\n";
			OutputTextBox3.Text += $"Month Names\r\n";
			for (int i = 0; i < 12; i++)
			{
				OutputTextBox1.Text += $"  {culture1.DateTimeFormat.MonthNames[i]}\r\n";
				OutputTextBox2.Text += $"  {culture2.DateTimeFormat.MonthNames[i]}\r\n";
				OutputTextBox3.Text += $"  {culture3.DateTimeFormat.MonthNames[i]}\r\n";
			}

		}

		private void ButtonC_Click(object sender, RoutedEventArgs e) {
			var culture1 = new System.Globalization.CultureInfo("en-US");
			var culture2 = new System.Globalization.CultureInfo("fr-BE");
			var culture3 = new System.Globalization.CultureInfo("zh-SG");

			OutputTextBox1.Text += $"Day Names\r\n";
			OutputTextBox2.Text += $"Day Names\r\n";
			OutputTextBox3.Text += $"Day Names\r\n";
			for (int i = 0; i < 7; i++)
			{
				OutputTextBox1.Text += $"  {culture1.DateTimeFormat.DayNames[i]}\r\n";
				OutputTextBox2.Text += $"  {culture2.DateTimeFormat.DayNames[i]}\r\n";
				OutputTextBox3.Text += $"  {culture3.DateTimeFormat.DayNames[i]}\r\n";
			}
		}
	}
}
