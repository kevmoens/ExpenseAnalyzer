using System;
namespace ExpenseAnalyzer.Expense
{
	public class Category
	{
		public Category()
		{
		}
        public bool? Selected { get; set; }
        public string? Name { get; set; }
		public List<string> Conditions { get; set; } = new List<string>();
    }
}

