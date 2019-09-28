using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
			List<RayPoint> points = new List<RayPoint> { new RayPoint(3, 6), new RayPoint(4, 8) };
			try
			{
				points.Sort();
			} catch (Exception ex)
			{

				OutputToScreen(ex.Message);
			}
			
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			string[] wordsArray = { "neat", "feét", "féet", "heat" };
			

			OutputToScreen("Original Array");
			foreach (var word in wordsArray)
			{
				OutputToScreen(word);
			}
			Array.Sort(wordsArray);
			OutputToScreen("-----");
			OutputToScreen("Sorted Array");
			foreach (var word in wordsArray)
			{
				OutputToScreen(word);
			}
		
		}
		private void OutputToScreen(string message) {

			OutputTextBox.Text += $"{message}\r\n";
		}

		private void ButtonC_Click(object sender, RoutedEventArgs e) {
			var wordsList = new List<string> { "neat", "feét", "féet", "heat", "defeat" };
			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
			var query = wordsList.OrderBy(x => x);

			OutputToScreen("Original List");
			foreach (var word in wordsList)
			{
				OutputToScreen(word);
			}

			OutputToScreen("-----");
			OutputToScreen("Sorted List (US)");

			foreach (var word in query)
			{
				OutputToScreen(word);
			}

			Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
			OutputToScreen("-----");
			OutputToScreen("Sorted List (FR)");
			foreach (var word in query)
			{
				OutputToScreen(word);
			}

		}
	}
	public class RayPoint {

		public RayPoint() {
			
		}

		public RayPoint(int x, int y) {
			X = x;
			Y = y;
		}
		public int X { get; set; }
		public int Y { get; set; }
	}
}
