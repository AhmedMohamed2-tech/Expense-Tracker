namespace Expense_Tracker
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public ExpenseLinkedList Expenses { get; set; }

        public User()
        {
            Expenses = new ExpenseLinkedList();
        }
    }
}
