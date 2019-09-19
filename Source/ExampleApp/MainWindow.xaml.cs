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
			char c1;

			string letters = "abc-def-ghi-jkl-mno-pqr-stu-vwx-yz";

			c1 = letters[0];
			c1 = letters[letters.Length - 1];
		
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			//char c1 = "5";

			//string letters = "abc-def-ghi-jkl-mno-pqr-stu-vwx-yz";
			//letters[0] = c1;
		}

		private void ButtonC_Click(object sender, RoutedEventArgs e) {
			// determine if a char exists within string
			char c1 = 'm';
			char resultChar;

			string letters = "abc-def-ghi-jkl-mno-pqr-stu-vwx-yz";
			if (letters.Contains(c1))
			{
				resultChar = letters[letters.IndexOf(c1)];
			}
		}
	}
}
