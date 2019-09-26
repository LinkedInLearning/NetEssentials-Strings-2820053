using System;
using System.Windows;

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

		private void ClearButton_Click(object sender, RoutedEventArgs e)
		{
			OutputTextBox.Text = string.Empty;
		}

		private void ButtonA_Click(object sender, RoutedEventArgs e)
		{
			// https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings
			// "d"	Short date pattern.
			// "D"	Long date pattern.

			DateTime date1 = new DateTime(year: 2002, month: 7, day: 29, 
																		hour: 9, minute: 19, second: 29);

			OutputToScreen(date1.ToString());

			try
			{
				OutputToScreen($"Short date:\t(D)\t{date1:D}");
				OutputToScreen($"Long date\t(d)\t{date1:d}");
				OutputToScreen($"Long time\t(T)\t{date1:T}");
				OutputToScreen($"Short time\t(t)\t{date1:t}");

				OutputToScreen($"General\t(G)\t{date1:G}");
				OutputToScreen($"Month Day\t(M)\t{date1:M}");
				OutputToScreen($"Year\t(Y)\t{date1:Y}");
				OutputToScreen($"Sortable\t(s)\t{date1:s}");
				OutputToScreen($"Sortable\t(s)\t{date1.AddDays(2):s}");
			} catch (Exception)
			{
				OutputToScreen("Cannot use that formatter.");
			}
		}

		private void OutputToScreen(string message)
		{
			OutputTextBox.Text += message + "\r\n";
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e)
		{
			// https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings

			DateTime date1 = new DateTime(year: 2002, month: 7, day: 29, 
																		hour: 9, minute: 19, second: 29);
			OutputToScreen(date1.ToString());
			try
			{
				OutputToScreen($"dd-MM-yy:\t\t{date1:dd-MM-yy}");
				OutputToScreen($"mm^HH^ss:\t\t{date1:mm^HH^ss}");
				OutputToScreen($"Year:(yyyy) \"Month\"(MM):\t{date1:Year:(yyyy) \"Month\"(MM)}");
			} catch (Exception)
			{
				OutputToScreen("Cannot use that formatter.");
			}
		}
	}
}