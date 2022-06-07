using System;
namespace ExpenseAnalyzer.Expense
{
	public class Transaction
	{
		public Transaction()
		{
		}
        public string? Type { get; set; }
		public DateTime? TrxDate { get; set; }
        public string? Description { get; set; }
		public double? Amount { get; set; }
		public string? Category { get; set; } = "UNDEFINED";
    }
}

