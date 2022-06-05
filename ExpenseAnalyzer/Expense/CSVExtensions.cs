using System;
namespace ExpenseAnalyzer.Expense
{
	public static class CSVExtensions
	{
		public static DateTime? ToDateTime(this string text)
        {
			DateTime date = DateTime.MinValue;
			if (DateTime.TryParse(text, out date))
            {
				return date;
            }
			return null;
		}

		public static double? ToDouble(this string text)
		{
			Double dbl = Double.MinValue;
			if (Double.TryParse(text, out dbl))
			{
				return dbl;
			}
			return null;
		}
		public static string CleanDescription(this string text)
        {
			var clean = text;
			if (clean.StartsWith("DDA PUR "))
            {
				clean = clean.Substring(8);
            }
			if (clean.StartsWith("DDA "))
			{
				clean = clean.Substring(4);
			}
			return clean;
        }
	}
}

