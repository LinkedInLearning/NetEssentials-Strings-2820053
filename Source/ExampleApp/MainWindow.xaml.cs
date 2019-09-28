using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

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
			var firstWord = "aabb";
			var secondWord = "aaBb";

			// the == operator always uses ordinal comparison
			var areEqual = firstWord == secondWord;

			// Ordinal is the fastest way to compare two strings.
			areEqual = firstWord.Equals(secondWord);
			// Use the overload that specifies a StringComparison.
			areEqual = firstWord.Equals(secondWord, StringComparison.Ordinal);

			// ignore case, but still do ordinal compare
			areEqual = firstWord.Equals(secondWord, StringComparison.OrdinalIgnoreCase);

			//static version
			areEqual = String.Equals(firstWord, secondWord, StringComparison.Ordinal);
		}
		public void ExampleSlideCode() {
			bool areEqual;

			areEqual = String.Equals("banana", "Banana");

			// change the default comparison with the StringComparison enumeration
			areEqual = String.Equals("banana", "Banana",
																StringComparison.Ordinal);
			areEqual = String.Equals("banana", "Banana",
																StringComparison.OrdinalIgnoreCase);

			areEqual = String.Equals("banana", "Banana",
																StringComparison.CurrentCulture);
			areEqual = String.Equals("banana", "Banana",
																StringComparison.CurrentCultureIgnoreCase);

			areEqual = String.Equals("banana", "Banana",
																StringComparison.InvariantCulture);
			areEqual = String.Equals("banana", "Banana",
																		StringComparison.InvariantCultureIgnoreCase);



			areEqual = "banana" == "Banana";
			// same as
			areEqual = String.Equals("banana", "Banana");

			areEqual = "banana" != "Banana";
			// same as
			areEqual = !String.Equals("banana", "Banana");

			int sortOrder;

			sortOrder = String.Compare("fig", "fit");


			var threeLetterWords = new List<string> { "zip", "car", "ant" };
			// OrderBy looks for IComparable.CompareTo
			var query = threeLetterWords.OrderBy(x => x);

			Console.WriteLine(areEqual);
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			if (String.Equals(PasswordBox1.Password, "secret", StringComparison.Ordinal))
			{
				OutputTextBox.Text += $"Login Success\r\n";
			}
			else
			{
				OutputTextBox.Text += $"Login Failed\r\n";
			}
		}
	}

	public class Methods {
		// System.String class

		public static bool Equals(string a, string b) {
			return true;
		}

		public static int Compare(string a, string b) {
			a = "";
			b = "";
			return 0;
		}


	}
}