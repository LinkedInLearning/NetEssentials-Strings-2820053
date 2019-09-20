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



		private void ButtonA_Click(object sender, RoutedEventArgs e) {

			var vscan = new VirusScanService();
			string combo = string.Empty;

			combo = vscan.CreateReportConcat();

			OutputTextBox.Text = combo;
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			var vscan = new VirusScanService();
			string combo = string.Empty;

			combo = vscan.CreateReport();

			OutputTextBox.Text = combo;
		}

		private void ClearButton_Click(object sender, RoutedEventArgs e)
		{
			OutputTextBox.Text = string.Empty;
		}
	}
	public class VirusScanService {
		// simulate dynamic list of files to scan.
		private Random _ran = new Random();
		private StringBuilder _builder = new StringBuilder();

		public string CreateReportConcat() {
			string result = string.Empty;

			result +="Virus Scan Report\v";
			result +="-=-=-=-=-=-=-=-=-=-=-=-=-\v";
			for (int counter = 0; counter < 4000; counter++)
			{
				result +=GetFileStatusReport();
				result +="\v";
			}

			return result;

		}
		public string CreateReport() {
			if (_builder.Capacity < 200000)
			{
				_builder = new StringBuilder(200000);
			}
			_builder.Clear();
			_builder.Append("Virus Scan Report\v");
			_builder.Append("-=-=-=-=-=-=-=-=-=-=-=-=-\v");
			for (int counter = 0; counter < 4000; counter++)
			{
				_builder.Append(GetFileStatusReport());
				_builder.Append ("\v");
			}
		
			return _builder.ToString();

		}
		private string GetFileStatusReport() {
	
			bool virusFound = (_ran.Next(2) == 0);
			DateTime scanTime = DateTime.Now.AddMinutes(_ran.Next(0, 10));
		string result = $"File: \t{GetModifiedFileName()} \t\tScanned {scanTime.ToShortTimeString()}  \tVirus Found ({virusFound})";
			return result;
		}
		private string GetModifiedFileName() {

			return System.IO.Path.GetRandomFileName();
		}
	}
	
}
