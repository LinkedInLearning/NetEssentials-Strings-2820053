using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExampleApp {
	public class RayPoint : Object {

		public static RayPoint Parse(string value) {
			// There are many ways to process the input string
			// Regex is another option, to parse the string.
			// for details, learn more in our catalog	


			//string parsedString = value.Trim();
			var cleanedString = Regex.Replace(value, "[^0-9,-]", "");
			string[] comma = { "," };
			var splitValues = cleanedString.Split(comma, StringSplitOptions.RemoveEmptyEntries);

			if (splitValues.Length > 2 || splitValues.Length < 2)
			{

				throw new InvalidCastException($"Cannot parse the value ({value}) into a RayPoint");
			}

			List<int> numbers = new List<int>(Array.ConvertAll(splitValues, int.Parse));

			return new RayPoint(numbers[0], numbers[1]);
		}


		#region ToString
		public override string ToString() {
			return ToString("C");
		}

		public string ToString(string format) {

			var currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
			return ToString(format, currentCulture);

		}

		public string ToString(string format, IFormatProvider formatProvider) {
			// use this implementation to 
			// process other cultures (passed via the IFormatProvider)
			// move the code here from other ToString("H")
			string formattedString;
			switch (format)
			{
				case "C":
					formattedString = $"X: {X}, Y:{Y}";
					break;
				case "H":
					formattedString = $"X: {X} - Y:{Y}";
					break;
				case "F":
					formattedString = $"X: {X} --++-- Y:{Y}";
					break;
				default:
					formattedString = $"X: {X}, Y:{Y}";
					break;
			}
			return formattedString;
		}
		#endregion
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
