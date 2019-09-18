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

		private void ButtonA_Click(object sender, RoutedEventArgs e)
		{
			// Strings are immutable, once created its characters cannot be changed.
			// Any action that looks like it is modifying the string
			// causes a new string to be created in memory.

			var s1 = "hello"; // s1 is initialized
			s1.ToUpper(); // returns a new string, but we don't use it.

			// declare a new string variable to hold the uppercase string
			var s2 = s1.ToUpper();
			s1 = s1.ToUpper();


		}

		private void ButtonB_Click(object sender, RoutedEventArgs e)
		{
			var dice1 = new Dice();
			dice1.PipCount = 6;
			var dice2 = dice1; // both variables refer to the same object

			dice2.PipCount = 14;

		}

		private void ButtonC_Click(object sender, RoutedEventArgs e)
		{
			var s1 = "hello";
			var s2 = s1; // another string is created, not a reference to first string

			s2 = "goodbye";


		}

		private void ButtonD_Click(object sender, RoutedEventArgs e)
		{
			// where this can be misunderstood
			// is assigning back to the same variable.

			var s1 = " Our award winning cooks have crafted signature dishes. Sign up for our cooks table tour. ";

			s1 = s1.Trim().Replace("cooks", "chefs").Replace(".", "!");
		}
	}
	public class Dice
	{
		public int PipCount { get; set; }

	}

}
