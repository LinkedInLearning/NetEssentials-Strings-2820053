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

		private void ButtonA_Click(object sender, RoutedEventArgs e) {
			// declare a string variable with the .NET class

			System.String s1;
			String s2;

			// declare a string variable with the C# keyword
			string s3;

		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			// the string is a reference type, which defaults to a null reference if not initialized

			string s;
			s = null;
			int currentLength = s.Length;
		}
	}
}
