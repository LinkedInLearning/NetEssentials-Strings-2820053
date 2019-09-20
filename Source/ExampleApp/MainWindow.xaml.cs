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
			// There is no runtime difference between a string and verbatim string. 
			// The C# compiler modifies verbatim strings, performing extra operations 

			string s1;

			s1 = "A file path\vC:\\Windows\\Users";
			OutputTextBox.Text = s1;
		}


		private void ClearButton_Click(object sender, RoutedEventArgs e) {
			OutputTextBox.Text = string.Empty;
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			string s2;

			s2 = @"A file path\vC:\\Windows\\Users";
			OutputTextBox.Text = s2;
		}

		private void ButtonC_Click(object sender, RoutedEventArgs e) {
			string s3, s4;
			
			s3 = "aa\tbb\tcc";
			// the C# compiler changes \t to \\t in the verbatim string
			s4 = @"aa\tbb\tcc"; 
			OutputTextBox.Text = s3;
		}

		private void ButtonD_Click(object sender, RoutedEventArgs e) {

			string s5;
			// the C# compiler adds \r\n for each newline in the verbatim string
			s5 = @"Select ProductName Price
             From Products
             Where price >23
             Order By Price";
			OutputTextBox.Text = s5;
		}
	}
}
