using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExampleApp {
	public class RayPoint : Object {

		public static RayPoint Parse(string value) {
			// we can use Regex to parse the string.
			// for details, learn more in our catalog
			//


			string parsedString = value.Trim();
			// Regex split on non digit values
			var splitValues = Regex.Split(parsedString, @"\D+");
			List<int> numbers = new List<int>(Array.ConvertAll(splitValues, int.Parse));

			if (splitValues.Length > 2 || splitValues.Length < 2)
			{
				throw new InvalidCastException($"Cannot parse the value ({value} into a RayPoint)");
			}
			return new RayPoint(numbers[0], numbers[1]);
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
