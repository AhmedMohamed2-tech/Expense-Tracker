using System;
using System.Collections.Generic;
using System.Linq;

namespace Expense_Tracker
{
    public class Expense
    {
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
    public static class ExpenseExtensions
    {
        public static List<Expense> QueryByDateRange(this List<Expense> expenses, DateTime startDate, DateTime endDate)
        {
            return expenses.Where(e => e.Date >= startDate && e.Date <= endDate).ToList();
        }
    }
}
