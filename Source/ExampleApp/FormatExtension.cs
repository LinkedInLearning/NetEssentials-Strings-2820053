namespace ExampleApp {

	public static class FormatExtension {

		public static string FormatAsOrdinal(this int number) {
			// 1st, 2nd, 3rd, 4th, 5th, 6th, 7th, 9th, 10th
			// 21st, 22nd, 23rd, 24th, etc
			// 31st, 32nd, 33rd, 34th, etc
			// 11th, 12th, 13th are special cases

			// Walt's thought for the day!
			// why don't we say tenny-one, tenny-two, tenny-three, tenny-four etc.

			string numString = number.ToString();
			string ordinalString = string.Empty;

			// process the special cases first
			if (numString.EndsWith("11")) return $"{numString}th";
			if (numString.EndsWith("12")) return $"{numString}th";
			if (numString.EndsWith("13")) return $"{numString}th";
			// process the rest
			if (numString.EndsWith("1")) return $"{numString}st";
			if (numString.EndsWith("2")) return $"{numString}nd";
			if (numString.EndsWith("3")) return $"{numString}rd";

			// all other numbers
			return $"{numString}th";
		}
	}
}