﻿using System;
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
			// syntax for string literal

			string s1, s2, s3, s4;

			s1 = "hello"; // string literal
			s2 = @"hello";  // verbatim string literal
			s3 = $"hello";  // interpolated string literal

			s4 = @"Select productName, 
Price from Products 
where Price > 21";

			
		}

		private void ClearButton_Click(object sender, RoutedEventArgs e)
		{
			OutputTextBox.Text = string.Empty;
		}
	}
}
