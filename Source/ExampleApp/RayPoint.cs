using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp {
	public class RayPoint : Object, IFormattable {

		public override string ToString() {
			return ToString("C");
		}

		public string ToString(string format) {

			var currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
			return ToString(format, currentCulture);
			
		}

		//public string ToString(string format, IFormatProvider formatProvider) {
		//	// use this implementation to 
		//	// process other cultures (passed via the IFormatProvider)
		//	// move the code here from other ToString("H")
		//	string formattedString;
		//	switch (format)
		//	{
		//		case "C":
		//			formattedString = $"X: {X}, Y:{Y}";
		//			break;
		//		case "H":
		//			formattedString = $"X: {X} - Y:{Y}";
		//			break;
		//		case "F":
		//			formattedString = $"X: {X} --++-- Y:{Y}";
		//			break;
		//		default:
		//			formattedString = $"X: {X}, Y:{Y}";
		//			break;
		//	}
		//	return formattedString;
		//}

		public string ToString(string format, IFormatProvider formatProvider) {

			var cultureInfo = formatProvider as System.Globalization.CultureInfo;
			var separator = cultureInfo.TextInfo.ListSeparator;
			var numSeparator = cultureInfo.NumberFormat.NumberDecimalSeparator;
			string formattedString;
			switch (format)
			{
				case "C":
					formattedString = $"X: {X}{separator} Y:{Y}";
					break;
				case "H":
					formattedString = $"X: {X} - Y:{Y}";
					break;
				case "F":
					formattedString = $"X: {X} --++-- Y:{Y}";
					break;
				default:
					formattedString = $"X: {X}{separator} Y:{Y}";
					break;
			}
			return formattedString;
		}
		#region Constructors
		public RayPoint() {

		}

		public RayPoint(int x, int y) {
			_x = x;
			_y = y;
		}
		#endregion
		#region Properties


		private int _x;

		public int X
		{
			get { return _x; }
			set { _x = value; }
		}

		private int _y;

		public int Y
		{
			get { return _y; }
			set { _y = value; }
		}

		#endregion
	}
}
