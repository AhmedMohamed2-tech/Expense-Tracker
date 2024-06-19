using System.Collections.Generic;

namespace Expense_Tracker
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<Expense> Expenses { get; set; } = new List<Expense>();
    }
}
