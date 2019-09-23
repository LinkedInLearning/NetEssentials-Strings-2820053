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

		private void ClearButton_Click(object sender, RoutedEventArgs e) {
			OutputTextBox.Text = string.Empty;
		}

		private void ButtonA_Click(object sender, RoutedEventArgs e) {
			// code challenge #1
			// write a method that takes a start word and end word and returns
			// the substring contained between those words.

			// code challenge #2
			// write another method that takes a start word and end word and replacement string
			// and returns a string containing the substitute text.

			string sample = "At Roux Academy, our mission is to teach and inspire the next generation’s artists...";
			string startWord = "our";
			string endWord = "the ";
			OutputTextBox.Text += sample + "\r\n";

			string result = string.Empty;

			result = sample.Substring(20, 33);
			result = GetSubStringBetweenWords(sample, startWord, endWord);
			OutputTextBox.Text += result + "\r\n";
			result = ReplaceBetweenWords(sample, startWord, endWord, " quest is to inspire and mentor ");

			OutputTextBox.Text += result + "\r\n";
		}

		#region "Code Challenge solution"

		public string GetSubStringBetweenWords(string candidate, string firstWord, string lastWord) {
			string result = string.Empty;
			int firstSnipPointIndex, lastSnipPointIndex;

			if (DoesFirstAndLastWordExist(candidate, firstWord, lastWord))
			{
				firstSnipPointIndex = candidate.IndexOf(value: firstWord, 
																				startIndex: 0) + firstWord.Length;
				lastSnipPointIndex = candidate.IndexOf(value: lastWord, 
																			startIndex: firstSnipPointIndex);
				return candidate.Substring(startIndex: firstSnipPointIndex, 
																		length: lastSnipPointIndex - firstSnipPointIndex);
			}
			else
			{
				return string.Empty;
			}

		}
		private bool DoesFirstAndLastWordExist(string candidate, string firstWord, string lastWord) {
			return (candidate.Contains(firstWord) && candidate.Contains(lastWord));

		}
		public string ReplaceBetweenWords(string candidate, string firstWord, string lastWord, string replacementText) {
			int firstSnipPointIndex, lastSnipPointIndex;

			// "this is " "the new value " "in the string"

			if (DoesFirstAndLastWordExist(candidate, firstWord, lastWord))
			{
				firstSnipPointIndex = candidate.IndexOf(value: firstWord, 
																						startIndex: 0) + firstWord.Length;
				string firstSubstring = candidate.Substring(startIndex: 0, 
																								length: firstSnipPointIndex);

				lastSnipPointIndex = candidate.IndexOf(value: lastWord, 
																					startIndex: firstSnipPointIndex);
				
				// use remove or substring to get the end part of the string!
				string lastSubString = candidate.Remove(startIndex: 0, 
																								count: lastSnipPointIndex);
				lastSubString = candidate.Substring(startIndex: lastSnipPointIndex, 
																						length: candidate.Length - lastSnipPointIndex);

				return $"{firstSubstring}{replacementText}{lastSubString}"; ;
			}
			else
			{
				return string.Empty;
			}
		}
		#endregion
	}
}
