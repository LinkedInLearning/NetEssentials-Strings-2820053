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

			string letters = "abcdefghijklmnopqrstuvwxyz";

			c1 = letters[0];
			c1 = letters[letters.Length - 1];
			if (letters.Contains(c1)
			{

			}
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			//char c1 = "5";

			//string letters = "abcdefghijklmnopqrstuvwxyz";
			//letters[0] = c1;
		}
	}
}
