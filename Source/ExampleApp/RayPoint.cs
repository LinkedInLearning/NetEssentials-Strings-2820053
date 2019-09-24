using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp {
	public class RayPoint : Object, IFormattable {

		public override string ToString() {
			return $"From ToString()";
		}
		public string ToString(string format) {
			return $"From ToString(format): (\"{format}\")";
		}
		public string ToString(string format, IFormatProvider formatProvider) {
			// format is the string that indicate what format to apply
			// for Double type, the "P" indicates to format as percent
			// for DateTime type, the "D" indicates to format as Long Date

			// the IFormatProvider, for most implementations
			// is where we provide the CultureInfo information.
			return $"From ToString(format, formatProvider): (\"{format}\", {formatProvider})";
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
