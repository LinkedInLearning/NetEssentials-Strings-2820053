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
			string s1, s2, s3, s5;

			s1 = "";
			s2 = String.Empty;
			s3 = "hello";
			var s4 = GetTourName();

		}

		private string GetTourName()
		{
			return "Museum Tour";
		}
	}
}
