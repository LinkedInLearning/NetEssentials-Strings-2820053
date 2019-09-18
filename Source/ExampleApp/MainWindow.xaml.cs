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

		private void ButtonA_Click(object sender, RoutedEventArgs e)
		{
			// Chars in .NET are 16-bit Unicode code values
			// A string consists of zero or more Chars
			// Internally the text is stored as a sequential read-only collection of Char objects.



			
			// A Char represents a single UNICODE character
			// https://unicode-table.com/en/

			Char c1, c2, c3, c4, c5;



		}
	}
}
