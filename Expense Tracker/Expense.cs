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
}
